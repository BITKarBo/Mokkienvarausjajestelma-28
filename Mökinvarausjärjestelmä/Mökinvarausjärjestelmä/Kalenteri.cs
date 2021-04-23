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
    public partial class Kalenteri : Form
    {

        public Kalenteri()
        {

            InitializeComponent();
        }

        private void Kalenteri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vNDataset.varaus' table. You can move, or remove it, as needed.
            string sqlcommand = "SELECT `varaus_id` AS 'VarausID', asiakas.etunimi AS 'Etunimi', asiakas.sukunimi AS 'Sukunimi', `varattu_alkupvm` AS 'Alkaa', `varattu_loppupvm` AS 'Päättyy' FROM varaus, asiakas WHERE varaus.asiakas_id = asiakas.asiakas_id";
            OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies");
            OdbcDataAdapter adapter = new OdbcDataAdapter(sqlcommand, connection);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(dt);
                varausBindingSource = new BindingSource();
                varausBindingSource.DataSource = dt;
                dataGridViewVaraukset.DataSource = varausBindingSource;
                connection.Close();
                
            }
            catch (Exception exx)
            {
                Console.Write(exx.Message);
            }

        }

        private void TbHaku_Enter(object sender, EventArgs e)
        {
            if (TbHaku.Text == "ID Haku")
            {
                TbHaku.Text = "";
            }
        }

        private void btnHae_Click(object sender, EventArgs e)
        {


            if (TbHaku.Text == "" || TbHaku.Text == "ID Haku")
            {
                varausBindingSource.Filter = string.Format("Alkaa >= #{0:yyyy/MM/dd}# And Päättyy <= #{1:yyyy/MM/dd}#", dateTimePickerAloitus.Value, dateTimePickerLopetus.Value);

            }
            else
            {
                try
                {
                    bool isnum = int.TryParse(TbHaku.Text, out int numero);
                    if (isnum == true)
                    {
                        varausBindingSource.Filter = string.Format("VarausID = {0}", numero);
                    }
                    else
                    {
                        varausBindingSource.Filter = string.Format("Etunimi Like '{0}' Or Sukunimi Like '{1}'",  TbHaku.Text, TbHaku.Text);
                    }
                    

                }
                catch (Exception exx)
                {
                    Console.Write(exx.Message);
                }
            }
        }

        private void dataGridViewVaraukset_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Varaus Varaus = new Varaus();
            Varaus.Show();
        }
    }
}
