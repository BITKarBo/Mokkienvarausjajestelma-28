using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Odbc;

// TODO1: varauksien palvelut haku.
// TODO2: Uuden varauksen lisäys tietokantaan.
// TODO3: Tekstikenttien validoinnit.

namespace Mökinvarausjärjestelmä
{
    public partial class Varaus : Form
    {
        public Varaus()
        {
            InitializeComponent();
        }

        private void Varaus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vNDataset.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.vNDataset.varaus);
            // TODO: This line of code loads data into the 'vNDataset.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.vNDataset.asiakas);

            // TODO: This line of code loads data into the 'vNDataset.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.vNDataset.mokki);

            // TODO: This line of code loads data into the 'vNDataset.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.vNDataset.toimintaalue);

            
            //Lisätään palvelut clbPalvelu listaan. (Ei toimi halutulla tavalla vielä) 
            string sqlcommand = "SELECT * FROM palvelu";
            OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies");
            OdbcDataAdapter adapter = new OdbcDataAdapter(sqlcommand, connection);
            DataTable dtPalvelu = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(dtPalvelu);
                palveluBindingSource = new BindingSource();
                palveluBindingSource.DataSource = dtPalvelu;
                clbPalvelut.DataSource = palveluBindingSource;
                clbPalvelut.DisplayMember = "nimi";
                clbPalvelut.ValueMember = "palvelu_id";

                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnHaeMokit_Click(object sender, EventArgs e)
        {
            // Hake vapaana olevat mökit toimialueittain ja halutusta aikavälistä ja näytää ne datagridviewissä
            string sqlcommand = string.Format("SELECT * FROM mokki WHERE toimintaalue_id = {0} AND mokki_id NOT IN (SELECT mokki_mokki_id FROM varaus WHERE varattu_alkupvm BETWEEN '{1:yyyy-MM-dd}' AND '{2:yyyy-MM-dd}' AND varattu_loppupvm BETWEEN '{1:yyyy-MM-dd}' AND '{2:yyyy-MM-dd}');", cbToimintaalue.SelectedValue, dtpAlkupvm.Value, dtpLoppupvm.Value);
            OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies");
            OdbcDataAdapter adapter = new OdbcDataAdapter(sqlcommand, connection);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(dt);
                mokkiBindingSource = new BindingSource();
                mokkiBindingSource.DataSource = dt;
                dgvMokki.DataSource = mokkiBindingSource;
                connection.Close();

            }
            catch (Exception exx)
            {
                Console.Write(exx.Message);
            }
            
        }

        private void btnLisaaAsiakas_Click(object sender, EventArgs e)
        {
            Muokkaa Muokkaa = new Muokkaa();
            Muokkaa.Show();
        }

        private void btnHae_Click(object sender, EventArgs e)
        {   // haetaan varauksen mökin tiedot
            string sqlcommand = string.Format("SELECT * FROM mokki WHERE mokki_id IN (SELECT mokki_mokki_id FROM varaus WHERE varaus.varaus_id = {0})", tbVarausNro.Text);
            OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies");
            OdbcDataAdapter adapter = new OdbcDataAdapter(sqlcommand, connection);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(dt);
                mokkiBindingSource = new BindingSource();
                mokkiBindingSource.DataSource = dt;
                dgvMokki.DataSource = mokkiBindingSource;
                connection.Close();

            }
            catch (Exception exx)
            {
                Console.Write(exx.Message);
            }
            cbToimintaalue.SelectedValue = dgvMokki.FirstDisplayedCell.Value.ToString();

            // Haetaan varauksen päivämäärät ja asiakas tiedot.
            string queryStr = string.Format("SELECT varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm, asiakas_id FROM varaus WHERE varaus_id = {0}", tbVarausNro.Text);
            using (OdbcConnection con = new OdbcConnection("Dsn=Village Newbies"))
            {
                OdbcCommand command = new OdbcCommand(queryStr, con);

                con.Open();

                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dtpVarauspvm.Value = reader.GetDateTime(0);
                    dtpVahvistus.Value = reader.GetDateTime(1);
                    dtpAlkupvm.Value = reader.GetDateTime(2);
                    dtpLoppupvm.Value = reader.GetDateTime(3);
                    cbAsiakas_id.Text = reader.GetString(4);
                    
                }
                reader.Close();
            }
        }
    }
}
