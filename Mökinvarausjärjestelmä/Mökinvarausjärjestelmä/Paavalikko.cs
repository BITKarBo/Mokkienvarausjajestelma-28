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
    public partial class Paavalikko : Form
    {
        public Paavalikko()
        {
            InitializeComponent();
        }

        private void btnUusiVaraus_Click(object sender, EventArgs e)
        {
            var Varaus = new Varaus();
            Varaus.Show();
        }

        private void btnKalenteri_Click(object sender, EventArgs e)
        {
            var Kalenteri = new Kalenteri();
            Kalenteri.Show();
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            var Muokkaa = new Muokkaa();
            Muokkaa.Show();
        }

        private void Toimialueboksi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRaportti_Click(object sender, EventArgs e)
        {
            Raportointi raportti = new Raportointi();
            raportti.Show();
        }

        private void Paavalikko_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vNDataset.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.vNDataset.toimintaalue);

        }
    }
}
