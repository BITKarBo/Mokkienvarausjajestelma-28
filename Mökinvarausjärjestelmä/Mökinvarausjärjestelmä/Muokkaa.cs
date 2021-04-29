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

        private void Muokkaa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vNDataset.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.vNDataset.mokki);
            // TODO: This line of code loads data into the 'vNDataset.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.vNDataset.palvelu);
            // TODO: This line of code loads data into the 'vNDataset.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.vNDataset.lasku);

        }

       
        private void btnLisaaPalvelu_Click(object sender, EventArgs e) //lisää palvelun tietokantaan palvelut välilehdessä, kun välilehden tekstikenttiin on lisätty pyydetyt tiedot
        {
            Validate();
            palveluBindingSource.EndEdit();
            palveluTableAdapter.Update(this.vNDataset);
            palveluTableAdapter.Insert(long.Parse(tbPalvelu_id.Text), long.Parse(tbToimintaAlue_id.Text), tbNimi.Text, int.Parse(tbTyyppi.Text), tbKuvaus.Text, double.Parse(tbHinta.Text), double.Parse(tbAlv.Text));
         

        }

        
        private void btnPoistaPalvelu_Click(object sender, EventArgs e) //Poistaa valitun rivin Palvelut välilehden DataGridWievistä 
        {
            int rowIndex = dgwPalvelut.CurrentCell.RowIndex;
            dgwPalvelut.Rows.RemoveAt(rowIndex);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}