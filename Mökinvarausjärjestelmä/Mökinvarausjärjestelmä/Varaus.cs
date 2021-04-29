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

            

        }

        private void cbToimintaalue_Leave(object sender, EventArgs e)
        {
           // this.mokkiBindingSource.Filter = string.Format("toimintaalue_id = {0}", cbToimintaalue.SelectedValue.ToString());
        }

        private void btnHaeMokit_Click(object sender, EventArgs e)
        {
            // Hake vapaana olevat mökit toimialueittain ja halutusta aikavälistä ja näytää ne datagridviewissä
                // (voisi siirtä omaan funktioon ja tehä "Leave_toiminnot" kentille että dgv päivittyis ilman nappia")
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
    }
}
