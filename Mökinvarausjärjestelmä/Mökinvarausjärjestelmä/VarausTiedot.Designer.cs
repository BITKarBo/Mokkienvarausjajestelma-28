namespace Mökinvarausjärjestelmä
{
    partial class VarausTiedot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VarausTiedotPaneeli = new System.Windows.Forms.Panel();
            this.tableLayoutPanelVarauksenTiedot = new System.Windows.Forms.TableLayoutPanel();
            this.VarausTiedotPaneeli.SuspendLayout();
            this.SuspendLayout();
            // 
            // VarausTiedotPaneeli
            // 
            this.VarausTiedotPaneeli.Controls.Add(this.tableLayoutPanelVarauksenTiedot);
            this.VarausTiedotPaneeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarausTiedotPaneeli.Location = new System.Drawing.Point(0, 0);
            this.VarausTiedotPaneeli.Name = "VarausTiedotPaneeli";
            this.VarausTiedotPaneeli.Size = new System.Drawing.Size(784, 761);
            this.VarausTiedotPaneeli.TabIndex = 0;
            // 
            // tableLayoutPanelVarauksenTiedot
            // 
            this.tableLayoutPanelVarauksenTiedot.ColumnCount = 2;
            this.tableLayoutPanelVarauksenTiedot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVarauksenTiedot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVarauksenTiedot.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelVarauksenTiedot.Name = "tableLayoutPanelVarauksenTiedot";
            this.tableLayoutPanelVarauksenTiedot.RowCount = 2;
            this.tableLayoutPanelVarauksenTiedot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVarauksenTiedot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVarauksenTiedot.Size = new System.Drawing.Size(760, 737);
            this.tableLayoutPanelVarauksenTiedot.TabIndex = 0;
            // 
            // VarausTiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.VarausTiedotPaneeli);
            this.Name = "VarausTiedot";
            this.Text = "VarausTiedot";
            this.VarausTiedotPaneeli.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VarausTiedotPaneeli;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVarauksenTiedot;
    }
}