using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mökinvarausjärjestelmä
{
    public partial class Raportointi : Form
    {
        public Raportointi()
        {
            InitializeComponent();
        }

        private void Raportointi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vNDataset.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.vNDataset.varaus);

            // Query jolla saadaan varaukset joissa mökki toimialue tietty. määrä eroteltuna päivämäärillä. -> kesken
            
            string sqlcommand = "SELECT `varaus_id` AS 'VarausID', asiakas.etunimi AS 'Etunimi', asiakas.sukunimi AS 'Sukunimi', `varattu_alkupvm` AS 'Alkaa', `varattu_loppupvm` AS 'Päättyy' FROM varaus, asiakas WHERE varaus.asiakas_id = asiakas.asiakas_id";
            OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies");
            OdbcDataAdapter adapter = new OdbcDataAdapter(sqlcommand, connection);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                adapter.Fill(ds);
                this.chartMajoitukset.DataSource = ds.Tables[0];

                this.chartMajoitukset.Series[0].XValueMember = "paiva";

                this.chartMajoitukset.Series[0].YValueMembers = "maara";

                this.chartMajoitukset.DataBind();

                connection.Close();

            }
            catch (Exception exx)
            {
                Console.Write(exx.Message);
            }

            // Toinen Query palveluille. Query jossa varauksen_palvelut kaikki menneet palvelut ja lkm eroteltuna varaus ID:llä



        }
    }
}
