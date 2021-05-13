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
using iText.Layout;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout.Properties;


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
        }

        private void Varaus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vNDataset.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.vNDataset.lasku);
            // TODO: This line of code loads data into the 'vNDataset.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.vNDataset.palvelu);
            // TODO: This line of code loads data into the 'vNDataset.varaus' table. You can move, or remove it, as needed.
            this.varausTableAdapter.Fill(this.vNDataset.varaus);
            // TODO: This line of code loads data into the 'vNDataset.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.vNDataset.asiakas);
            // TODO: This line of code loads data into the 'vNDataset.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.vNDataset.mokki);
            // TODO: This line of code loads data into the 'vNDataset.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.vNDataset.toimintaalue);

            if (tbVarausNro.Text != "") 
            {
                btnHae.PerformClick();
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
                MessageBox.Show(exx.Message);
            }
            palveluBindingSource.Filter = string.Format("toimintaalue_id = {0}", cbToimintaalue.SelectedValue.ToString());
        }

        private void btnLisaaAsiakas_Click(object sender, EventArgs e)
        {
            Muokkaa Muokkaa = new Muokkaa(3);
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
                MessageBox.Show(exx.Message);
            }

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
                connection.Close();

                cbToimintaalue.SelectedValue = dgvMokki.Rows[0].Cells[0].Value.ToString();
                palveluBindingSource.Filter = string.Format("toimintaalue_id = {0}", cbToimintaalue.ValueMember.ToString());

                //hakee varauksen palvelut
                lbVarauksenPalvelut.Items.Clear(); 
                sqlcommand = string.Format("SELECT nimi FROM palvelu WHERE palvelu_id IN(SELECT palvelu_id FROM varauksen_palvelut WHERE varaus_id = {0})", tbVarausNro.Text);
                using (connection)
                {
                    command = new OdbcCommand(sqlcommand, connection);

                    connection.Open();

                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lbVarauksenPalvelut.Items.Add(reader.GetString(0));

                    }
                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            if (tbVarausNro.Text == "")
            { // lisää uuden varauksen.
                try
                {
                    Validate();
                    varausBindingSource.EndEdit();
                    varausTableAdapter.Update(this.vNDataset);
                    varausTableAdapter.Insert(int.Parse(cbAsiakas_id.Text), int.Parse(dgvMokki.SelectedRows[0].Cells[1].Value.ToString()), DateTime.Parse(dtpVarauspvm.Text), DateTime.Parse(dtpVahvistus.Text), DateTime.Parse(dtpAlkupvm.Text), DateTime.Parse(dtpLoppupvm.Text));

                    //lisää varauksen palvelut tauluun
                    for (int i = 0; i < lbVarauksenPalvelut.Items.Count; i++)
                    {
                        string sqlcommand = string.Format("INSERT INTO varauksen_palvelut VALUES((SELECT varaus_id FROM varaus WHERE varaus_id =(SELECT MAX(varaus_id) FROM varaus)), (SELECT palvelu_id FROM palvelu WHERE nimi = '{0}'), 1)", lbVarauksenPalvelut.Items[i]);
                        OdbcCommand command = new OdbcCommand(sqlcommand);
                        using (OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies"))
                        {
                            command.Connection = connection;
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Tallennus onnistui!");
                }
                catch (Exception exx) {
                    MessageBox.Show(exx.Message);
                }
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
                sqlcommand = string.Format("DELETE FROM varauksen_palvelut WHERE varaus_id = {0}", tbVarausNro.Text);
                command = new OdbcCommand(sqlcommand);
                using (OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies"))
                {
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                for (int i = 0; i < lbVarauksenPalvelut.Items.Count; i++)
                {
                    sqlcommand = string.Format("INSERT INTO varauksen_palvelut VALUES({0}, (SELECT palvelu_id FROM palvelu WHERE nimi = '{1}'), 1)", tbVarausNro.Text, lbVarauksenPalvelut.Items[i]);
                    command = new OdbcCommand(sqlcommand);
                    using (OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies"))
                    {
                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

            }

            

        }

        private void btnSiirra_Click(object sender, EventArgs e)
        {      
            lbVarauksenPalvelut.Items.Add(lbPalvelut.SelectedValue.ToString()); 
        }

        private void btnPoistaPalvelu_Click(object sender, EventArgs e)
        {
            lbVarauksenPalvelut.Items.Remove(lbVarauksenPalvelut.SelectedItem);
        }

        
        private void btnLasku_Click(object sender, EventArgs e)
        { //Generoidaan pdf pohjalle lasku varauksesta.
            int laskuID = 0;
            int varausID = int.Parse(tbVarausNro.Text);
            double[] hinta = new double[lbVarauksenPalvelut.Items.Count + 1];
            double[] alv = new double[lbVarauksenPalvelut.Items.Count + 1];
            string mokki = dgvMokki.SelectedRows[0].Cells[2].Value.ToString();
            string[] palvelut = new string[lbVarauksenPalvelut.Items.Count];
            double kokHinta = 0;
            int[] lkm = new int[lbVarauksenPalvelut.Items.Count + 1];

            OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies");
            string sqlcommand = string.Format("SELECT hinta, alv FROM mokki WHERE mokki_id = {0}", dgvMokki.SelectedRows[0].Cells[0].Value.ToString());
            using (connection)
            {
                OdbcCommand command = new OdbcCommand(sqlcommand, connection);

                connection.Open();

                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    hinta[0] = reader.GetDouble(0);
                    alv[0] = reader.GetDouble(1);
                }
                reader.Close();
                connection.Close();
            }
            DateTime dt1 = dtpLoppupvm.Value;
            DateTime dt2 = dtpAlkupvm.Value;
            lkm[0] = (dt1 - dt2).Days;

            connection = new OdbcConnection("Dsn=Village Newbies");
            sqlcommand = string.Format("SELECT nimi, hinta, alv FROM palvelu WHERE palvelu_id IN(SELECT palvelu_id FROM varauksen_palvelut WHERE varaus_id = {0})", tbVarausNro.Text);
            if (lbVarauksenPalvelut.Items.Count != 0)
            {
                using (connection)
                {

                    OdbcCommand command = new OdbcCommand(sqlcommand, connection);

                    connection.Open();

                    OdbcDataReader reader = command.ExecuteReader();
                    int x = 0;
                    while (reader.Read())
                    {

                        palvelut[x] = reader.GetString(0);
                        hinta[x + 1] = reader.GetDouble(1);
                        alv[x + 1] = reader.GetDouble(2);
                        lkm[x + 1] = 1;
                        x++;
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            kokHinta = hinta[0] * (1 + alv[0]) * lkm[0];
            for (int i = 1; i < hinta.Length; i++) 
            {
                kokHinta += (hinta[i] * (1 + alv[i]) * lkm[i]);
            }


            var writer = new PdfWriter("C:/temp/lasku.pdf");
            var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            Paragraph header = new Paragraph("Village Newbies")
                .SetFontSize(20)
                .SetTextAlignment(TextAlignment.CENTER);
            LineSeparator ls = new LineSeparator(new SolidLine());

            Paragraph newline = new Paragraph(new Text("\n"));

            
            document.Add(header);
            document.Add(ls);
            document.Add(newline);

            document.Add(new Paragraph(string.Format("Asiakas:\n{0} {1}\n{2} {3}", tbEtunimi.Text, tbSukunimi.Text, tbLahiosoite.Text, tbPostinumero.Text)));

            document.Add(new Paragraph(string.Format("Varaus id: {0}", varausID)));
            
            Table table = new Table(5, true);
            table.AddCell(new Paragraph("Tuote"));
            table.AddCell(new Paragraph("Hinta"));
            table.AddCell(new Paragraph("Alv"));
            table.AddCell(new Paragraph("Määrä"));
            table.AddCell(new Paragraph("Kokonais hinta"));

            table.AddCell(new Paragraph(mokki));
            table.AddCell(new Paragraph(hinta[0].ToString()));
            table.AddCell(new Paragraph(alv[0].ToString()));
            table.AddCell(new Paragraph(lkm[0].ToString()));
            table.AddCell(new Paragraph(string.Format("{0}", hinta[0] * (1 + alv[0]) * lkm[0]))
                .SetTextAlignment(TextAlignment.RIGHT));

            for (int i = 0; i < lbVarauksenPalvelut.Items.Count; i++) 
            {
                table.AddCell(new Paragraph(palvelut[i]));
                table.AddCell(new Paragraph(hinta[i + 1].ToString()));
                table.AddCell(new Paragraph(alv[i + 1].ToString()));
                table.AddCell(new Paragraph(lkm[i + 1].ToString()));
                table.AddCell(new Paragraph(string.Format("{0}", hinta[i + 1] * (1 + alv[i + 1]) * 1))
                    .SetTextAlignment(TextAlignment.RIGHT));
            }

            document.Add(table);

            document.Add(new LineSeparator(new SolidLine()));
            document.Add(new Paragraph(string.Format("Maksettava: {0}€", kokHinta)).SetTextAlignment(TextAlignment.RIGHT));
            document.Add(new LineSeparator(new SolidLine()));
            document.Add(new Paragraph(string.Format("Käytä laskua maksaessa viitenumerona varaustunnusta: {0}", varausID)));
            document.Close();

            System.Diagnostics.Process.Start("C:/temp/lasku.pdf");

            try
            {
                Validate();
                laskuBindingSource.EndEdit();
                laskuTableAdapter.Update(this.vNDataset);
                laskuTableAdapter.Insert(varausID, varausID, kokHinta, alv[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
