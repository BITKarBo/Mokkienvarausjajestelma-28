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
// TODO3: Tekstikenttien validoinnit.


namespace Mökinvarausjärjestelmä
{
    public partial class Varaus : Form
    {
        public Varaus()
        {
            InitializeComponent();
        }

        public Varaus(string varausnum)
        {
            InitializeComponent();
            tbVarausNro.Text = varausnum;
            btnHaeMokit_Click(varausnum, EventArgs.Empty);
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
            OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies");
            string sqlcommand = "SELECT * FROM palvelu";
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
            OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies");
            string sqlcommand = string.Format("SELECT * FROM mokki WHERE toimintaalue_id = {0} AND mokki_id NOT IN (SELECT mokki_mokki_id FROM varaus WHERE varattu_alkupvm BETWEEN '{1:yyyy-MM-dd}' AND '{2:yyyy-MM-dd}' AND varattu_loppupvm BETWEEN '{1:yyyy-MM-dd}' AND '{2:yyyy-MM-dd}');", cbToimintaalue.SelectedValue, dtpAlkupvm.Value, dtpLoppupvm.Value);
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
            OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies");
            string sqlcommand = string.Format("SELECT * FROM mokki WHERE mokki_id IN (SELECT mokki_mokki_id FROM varaus WHERE varaus.varaus_id = {0})", tbVarausNro.Text);          
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
            sqlcommand = string.Format("SELECT varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm, asiakas_id FROM varaus WHERE varaus_id = {0}", tbVarausNro.Text);
            using (connection)
            {
                OdbcCommand command = new OdbcCommand(sqlcommand, connection);

                connection.Open();

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

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            if (tbVarausNro.Text == "")
            { // lisää uuden varauksen.
                Validate();
                varausBindingSource.EndEdit();
                varausTableAdapter.Update(this.vNDataset);
                varausTableAdapter.Insert(int.Parse(cbAsiakas_id.Text), int.Parse(dgvMokki.SelectedRows[0].Cells[1].Value.ToString()), DateTime.Parse(dtpVarauspvm.Text), DateTime.Parse(dtpVahvistus.Text), DateTime.Parse(dtpAlkupvm.Text), DateTime.Parse(dtpLoppupvm.Text));
            }
            else
            { //päivittää olemassa olevan varauksen.
                
                string sqlcommand = string.Format("UPDATE varaus SET asiakas_id = {0}, mokki_mokki_id = {1}, varattu_pvm = '{2:yyyy-MM-dd}', vahvistus_pvm = '{3:yyyy-MM-dd}', varattu_alkupvm = '{4:yyyy-MM-dd}', varattu_loppupvm = '{5:yyyy-MM-dd}' WHERE varaus_id = {6};",
                    int.Parse(cbAsiakas_id.Text), int.Parse(dgvMokki.SelectedRows[0].Cells[1].Value.ToString()), DateTime.Parse(dtpVarauspvm.Text), DateTime.Parse(dtpVahvistus.Text), DateTime.Parse(dtpAlkupvm.Text), DateTime.Parse(dtpLoppupvm.Text), int.Parse(tbVarausNro.Text));
                OdbcCommand command = new OdbcCommand(sqlcommand);
                using (OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies"))
                {
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
