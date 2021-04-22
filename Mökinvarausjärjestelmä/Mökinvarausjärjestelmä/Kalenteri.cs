﻿using System;
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
            if (TbHaku.Text == "ID Haku")
            {
                TbHaku.Text = "";
            }
        }

        private void btnHae_Click(object sender, EventArgs e)
        {


            if (TbHaku.Text == "" || TbHaku.Text == "ID Haku")
            {
                varausBindingSource.Filter = string.Format("varattu_alkupvm >= #{0:yyyy/MM/dd}# And varattu_loppupvm <= #{1:yyyy/MM/dd}#", dateTimePickerAloitus.Value, dateTimePickerLopetus.Value);

            }
            else
            {
                varausBindingSource.Filter = string.Format("varattu_alkupvm >= #{0:yyyy/MM/dd}# And varattu_loppupvm <= #{1:yyyy/MM/dd}# Or varaus_id = {2}", dateTimePickerAloitus.Value, dateTimePickerLopetus.Value, TbHaku.Text);
            }
        }

        private void dataGridViewVaraukset_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Varaus Varaus = new Varaus();

            Varaus.Show();
        }
    }
}
