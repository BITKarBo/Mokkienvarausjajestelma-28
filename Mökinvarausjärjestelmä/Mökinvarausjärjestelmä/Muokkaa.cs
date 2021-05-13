using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mökinvarausjärjestelmä
{
    public partial class Muokkaa : Form
    {
        public Muokkaa()
        {
            InitializeComponent();
        }

        public Muokkaa(int tab)
        {
            InitializeComponent();
            Mökit.SelectedIndex = tab;
        }
        private void Muokkaa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vNDataset.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.vNDataset.asiakas);
            // TODO: This line of code loads data into the 'vNDataset.posti' table. You can move, or remove it, as needed.
            this.postiTableAdapter.Fill(this.vNDataset.posti);
            // TODO: This line of code loads data into the 'vNDataset.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.vNDataset.toimintaalue);
            // TODO: This line of code loads data into the 'vNDataset.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.vNDataset.mokki);
            // TODO: This line of code loads data into the 'vNDataset.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.vNDataset.palvelu);
            // TODO: This line of code loads data into the 'vNDataset.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.vNDataset.lasku);

        }


        private void btnLisaaPalvelu_Click(object sender, EventArgs e) //lisää palvelun tietokantaan palvelut välilehdessä, kun välilehden tekstikenttiin on lisätty pyydetyt tiedot
        {
            try
            {
                Validate();
                palveluBindingSource.EndEdit();
                palveluTableAdapter.Update(this.vNDataset);
                palveluTableAdapter.Insert(long.Parse(tbPalvelu_id.Text), long.Parse(tbToimintaAlue_id.Text), tbNimi.Text, int.Parse(tbTyyppi.Text), tbKuvaus.Text, double.Parse(tbHinta.Text), double.Parse(tbAlv.Text));
            }
            catch (Exception)
            {
                Console.WriteLine("Mökki puuttuu tietokannasta, johon koitit palvelun lisätä");              
            }



        }


        private void btnPoistaPalvelu_Click(object sender, EventArgs e) //Poistaa valitun rivin Palvelut välilehden DataGridWievistä 
        {
            int rowIndex = dgwPalvelut.CurrentCell.RowIndex;
            dgwPalvelut.Rows.RemoveAt(rowIndex);
        }

        private void btnToimintaAlueLisaa_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                toimintaalueBindingSource.EndEdit();
                toimintaalueTableAdapter.Update(this.vNDataset);
                toimintaalueTableAdapter.Insert(tbToimintaAlueNimi.Text);
            }
            catch (Exception)
            {
                Console.WriteLine("Tapahtui virhe");
            }

        }

        private void btnToimintaAluePoista_Click(object sender, EventArgs e)
        {
            int rowIndex = dgwToimintaAlue.CurrentCell.RowIndex;
            dgwToimintaAlue.Rows.RemoveAt(rowIndex);
        }

        private void btnLisaaMokki_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                mokkiBindingSource.EndEdit();
                mokkiTableAdapter.Update(this.vNDataset);
                mokkiTableAdapter.Insert(long.Parse(cbToimintaAlue.SelectedValue.ToString()), tbMokinPostiNumero.Text, tbMokinNimi.Text, tbMokinOsoite.Text, tbMokinKuvaus.Text, int.Parse(tbMokinSangyt.Text), tbMokinVarustelu.Text);
            }
            catch (Exception)
            {
                Console.WriteLine("Mökkiä ei voitu lisätä, koska mökin toiminta-alue puuttuu tietokannasta");
              
            }
           
        }

        private void btnLisaaAsiakas_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                asiakasBindingSource.EndEdit();
                asiakasTableAdapter.Update(this.vNDataset);
                asiakasTableAdapter.Insert(tbAsiakkaanPostinumero.Text, tbAsiakkaanEtunimi.Text, tbAsiakkaanSukunimi.Text, tbAsiakkaanOsoite.Text, tbAsiakkaanSposti.Text, tbAsiakkaanPuhNum.Text);
            }
            catch (Exception)
            {
                Console.WriteLine("Jottai ei toivottua tapahtui");
               
            }
        }

        private void btnLuoLasku_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                laskuBindingSource.EndEdit();
                laskuTableAdapter.Update(this.vNDataset);
                laskuTableAdapter.Insert(int.Parse(tbLaskunNumero.Text), long.Parse(tbVarausTunnus.Text), double.Parse(tbLaskuSumma.Text), double.Parse(tbLaskuAlv.Text));
            }
            catch (Exception)
            {
                Console.WriteLine("Jottai ei toivottua tapahtui");
                
            }
        }

        private void btnPoistaLasku_Click(object sender, EventArgs e)
        {
            int rowIndex = dgwLaskut.CurrentCell.RowIndex;
            dgwLaskut.Rows.RemoveAt(rowIndex);
        }
    }
}