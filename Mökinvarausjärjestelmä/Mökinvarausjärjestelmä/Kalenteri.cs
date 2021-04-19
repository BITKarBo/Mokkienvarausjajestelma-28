using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
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
            this.varausTableAdapter.Fill(this.vNDataset.varaus);

        }

        private void TbHaku_Enter(object sender, EventArgs e)
        {
            if (TbHaku.Text == "Vapaa Haku Sana")
            {
                TbHaku.Text = "";
            }
        }

        private void btnHae_Click(object sender, EventArgs e)
        {

            
            if (TbHaku.Text != "")
            {
                if (TbHaku.Text == "Vapaa Haku Sana")
                {
                    TbHaku.Text = "0";
                }

                //
                // tapa käyttäen uutta ODBC yhteyttä
                //
                string hsana = ((TbHaku.Text).ToLower()).Replace(" ", "");                      // Hakusana SQL lauseelle
                string sqlClause = $"SELECT * FROM varaus WHERE varaus_id LIKE '%{hsana}%';";   // SQL lause Stringissä

                OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies");          // yhteys String

                Console.WriteLine(sqlClause);                                                   // printtaa vaa lauseen consolii
                OdbcCommand cmd = new OdbcCommand(sqlClause, connection);                       // luo komennon lauseista ja yhteydestä
                try
                {
                    connection.Open();                                                          // Yhteyden avaaminen
                                                                                                // Lukija datalle ja data tulee komennosta josta suoritetaan luku
                    OdbcDataReader reader = cmd.ExecuteReader(); 

                    while (reader.Read())                                                       // Readeri lukee datan joka tulee Tietokannasta
                    {
                        Console.WriteLine("Löytyy!");
                        for (int j = 0; j < 7; j++)
                        {
                            Console.Write(reader.GetName(j));                                   // printataan consoliin alustavasti löytynyt data GetName yms löytää taulusta datan...
                            Console.Write(" -> ");
                            Console.Write(reader.GetValue(j));
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine(" -> "); // nuoli :D
                //
                // Toinen tapa käyttäen Adapteria
                //
                    DataTable dt = varausTableAdapter.GetData();                                // Hakee datan Adapterista joka on siis vaa yhteys datasettiin joka taas Tietokantaan
                    //this.varausTableAdapter.FillBy();
                    
                    
                    foreach (DataRow row in dt.Rows)
                    {                                                                           // Tämä koodi ei toimi haussa juuri nyt
                        Console.WriteLine(row["varaus_id"]);                                    // Tässä tapauksessa Data pitää lukea läpi täsmäävällä Tiedon nimellä
                        Console.WriteLine(row["asiakas_id"]);
                        Console.WriteLine(row["mokki_mokki_id"]);
                        Console.WriteLine(row["varattu_pvm"]);
                    }
                    varausBindingSource.Filter = $"varaus_id = {hsana}";                        // filteröinti toimii :D binding sourcesta
                    reader.Close();                                                             // Yhteyksien sulkeminen
                    connection.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

        }

    }
}
