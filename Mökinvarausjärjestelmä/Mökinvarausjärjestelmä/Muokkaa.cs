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
            // TODO: This line of code loads data into the 'vNDataset.palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.vNDataset.palvelu);
            // TODO: This line of code loads data into the 'vNDataset.lasku' table. You can move, or remove it, as needed.
            this.laskuTableAdapter.Fill(this.vNDataset.lasku);

        }
    }
}