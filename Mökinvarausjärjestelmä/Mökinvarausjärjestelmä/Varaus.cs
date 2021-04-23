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
    public partial class Varaus : Form
    {
        public Varaus()
        {
            InitializeComponent();
        }

        private void Varaus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vNDataset.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.vNDataset.asiakas);

            // TODO: This line of code loads data into the 'vNDataset.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.vNDataset.mokki);
            // TODO: This line of code loads data into the 'vNDataset.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.vNDataset.toimintaalue);

            

        }

        private void cbToimintaalue_Leave(object sender, EventArgs e)
        {
            this.mokkiBindingSource.Filter = string.Format("toimintaalue_id = {0}", cbToimintaalue.SelectedValue.ToString());
        }
    }
}
