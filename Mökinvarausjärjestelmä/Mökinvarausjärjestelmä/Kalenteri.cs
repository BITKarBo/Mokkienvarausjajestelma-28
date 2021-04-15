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

        private void btnHae_Click(object sender, EventArgs e)
        {

        }
    }
}
