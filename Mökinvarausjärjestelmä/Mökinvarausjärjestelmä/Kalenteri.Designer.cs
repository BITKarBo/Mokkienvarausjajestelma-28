namespace Mökinvarausjärjestelmä
{
    partial class Kalenteri
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
            this.components = new System.ComponentModel.Container();
            this.KalenteriPaneeli = new System.Windows.Forms.Panel();
            this.KalenteriLayoutPaneeliVaraus = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLoppu = new System.Windows.Forms.Label();
            this.lblAlku = new System.Windows.Forms.Label();
            this.dateTimePickerAloitus = new System.Windows.Forms.DateTimePicker();
            this.btnHae = new System.Windows.Forms.Button();
            this.dateTimePickerLopetus = new System.Windows.Forms.DateTimePicker();
            this.lblMokkiVaraukset = new System.Windows.Forms.Label();
            this.TbHaku = new System.Windows.Forms.TextBox();
            this.dataGridViewVaraukset = new System.Windows.Forms.DataGridView();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkimokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahvistuspvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattualkupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattuloppupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vNDataset = new Mökinvarausjärjestelmä.VNDataset();
            this.varausTableAdapter = new Mökinvarausjärjestelmä.VNDatasetTableAdapters.varausTableAdapter();
            this.hakuToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.KalenteriPaneeli.SuspendLayout();
            this.KalenteriLayoutPaneeliVaraus.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaraukset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // KalenteriPaneeli
            // 
            this.KalenteriPaneeli.Controls.Add(this.KalenteriLayoutPaneeliVaraus);
            this.KalenteriPaneeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KalenteriPaneeli.Location = new System.Drawing.Point(0, 0);
            this.KalenteriPaneeli.Name = "KalenteriPaneeli";
            this.KalenteriPaneeli.Size = new System.Drawing.Size(797, 761);
            this.KalenteriPaneeli.TabIndex = 0;
            // 
            // KalenteriLayoutPaneeliVaraus
            // 
            this.KalenteriLayoutPaneeliVaraus.ColumnCount = 1;
            this.KalenteriLayoutPaneeliVaraus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.18421F));
            this.KalenteriLayoutPaneeliVaraus.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.KalenteriLayoutPaneeliVaraus.Controls.Add(this.dataGridViewVaraukset, 0, 1);
            this.KalenteriLayoutPaneeliVaraus.Location = new System.Drawing.Point(12, 12);
            this.KalenteriLayoutPaneeliVaraus.Name = "KalenteriLayoutPaneeliVaraus";
            this.KalenteriLayoutPaneeliVaraus.RowCount = 2;
            this.KalenteriLayoutPaneeliVaraus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.5441F));
            this.KalenteriLayoutPaneeliVaraus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.4559F));
            this.KalenteriLayoutPaneeliVaraus.Size = new System.Drawing.Size(783, 737);
            this.KalenteriLayoutPaneeliVaraus.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.Controls.Add(this.lblLoppu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAlku, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerAloitus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnHae, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerLopetus, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMokkiVaraukset, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TbHaku, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.29167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.70834F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 197);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblLoppu
            // 
            this.lblLoppu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoppu.AutoSize = true;
            this.lblLoppu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoppu.Location = new System.Drawing.Point(366, 10);
            this.lblLoppu.Name = "lblLoppu";
            this.lblLoppu.Size = new System.Drawing.Size(141, 25);
            this.lblLoppu.TabIndex = 2;
            this.lblLoppu.Text = "Lopetus PVM";
            // 
            // lblAlku
            // 
            this.lblAlku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlku.AutoSize = true;
            this.lblAlku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlku.Location = new System.Drawing.Point(81, 10);
            this.lblAlku.Name = "lblAlku";
            this.lblAlku.Size = new System.Drawing.Size(129, 25);
            this.lblAlku.TabIndex = 1;
            this.lblAlku.Text = "Aloitus PVM";
            // 
            // dateTimePickerAloitus
            // 
            this.dateTimePickerAloitus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerAloitus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAloitus.Location = new System.Drawing.Point(7, 49);
            this.dateTimePickerAloitus.Name = "dateTimePickerAloitus";
            this.dateTimePickerAloitus.Size = new System.Drawing.Size(276, 26);
            this.dateTimePickerAloitus.TabIndex = 4;
            // 
            // btnHae
            // 
            this.btnHae.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHae.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHae.Location = new System.Drawing.Point(602, 53);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(132, 82);
            this.btnHae.TabIndex = 3;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // dateTimePickerLopetus
            // 
            this.dateTimePickerLopetus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerLopetus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerLopetus.Location = new System.Drawing.Point(298, 49);
            this.dateTimePickerLopetus.Name = "dateTimePickerLopetus";
            this.dateTimePickerLopetus.Size = new System.Drawing.Size(277, 26);
            this.dateTimePickerLopetus.TabIndex = 5;
            // 
            // lblMokkiVaraukset
            // 
            this.lblMokkiVaraukset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMokkiVaraukset.AutoSize = true;
            this.lblMokkiVaraukset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokkiVaraukset.Location = new System.Drawing.Point(3, 157);
            this.lblMokkiVaraukset.Name = "lblMokkiVaraukset";
            this.lblMokkiVaraukset.Size = new System.Drawing.Size(109, 25);
            this.lblMokkiVaraukset.TabIndex = 0;
            this.lblMokkiVaraukset.Text = "Varaukset";
            // 
            // TbHaku
            // 
            this.TbHaku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbHaku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbHaku.Location = new System.Drawing.Point(300, 157);
            this.TbHaku.Name = "TbHaku";
            this.TbHaku.Size = new System.Drawing.Size(273, 26);
            this.TbHaku.TabIndex = 6;
            this.TbHaku.Text = "Vapaa Haku Sana";
            this.TbHaku.Enter += new System.EventHandler(this.TbHaku_Enter);
            // 
            // dataGridViewVaraukset
            // 
            this.dataGridViewVaraukset.AllowUserToAddRows = false;
            this.dataGridViewVaraukset.AutoGenerateColumns = false;
            this.dataGridViewVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVaraukset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn,
            this.asiakasidDataGridViewTextBoxColumn,
            this.mokkimokkiidDataGridViewTextBoxColumn,
            this.varattupvmDataGridViewTextBoxColumn,
            this.vahvistuspvmDataGridViewTextBoxColumn,
            this.varattualkupvmDataGridViewTextBoxColumn,
            this.varattuloppupvmDataGridViewTextBoxColumn});
            this.dataGridViewVaraukset.DataSource = this.varausBindingSource;
            this.dataGridViewVaraukset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVaraukset.Location = new System.Drawing.Point(3, 206);
            this.dataGridViewVaraukset.Name = "dataGridViewVaraukset";
            this.dataGridViewVaraukset.Size = new System.Drawing.Size(777, 528);
            this.dataGridViewVaraukset.TabIndex = 2;
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // mokkimokkiidDataGridViewTextBoxColumn
            // 
            this.mokkimokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.Name = "mokkimokkiidDataGridViewTextBoxColumn";
            // 
            // varattupvmDataGridViewTextBoxColumn
            // 
            this.varattupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.HeaderText = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.Name = "varattupvmDataGridViewTextBoxColumn";
            // 
            // vahvistuspvmDataGridViewTextBoxColumn
            // 
            this.vahvistuspvmDataGridViewTextBoxColumn.DataPropertyName = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.HeaderText = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.Name = "vahvistuspvmDataGridViewTextBoxColumn";
            // 
            // varattualkupvmDataGridViewTextBoxColumn
            // 
            this.varattualkupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.HeaderText = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.Name = "varattualkupvmDataGridViewTextBoxColumn";
            // 
            // varattuloppupvmDataGridViewTextBoxColumn
            // 
            this.varattuloppupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.HeaderText = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.Name = "varattuloppupvmDataGridViewTextBoxColumn";
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.vNDataset;
            // 
            // vNDataset
            // 
            this.vNDataset.DataSetName = "VNDataset";
            this.vNDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // hakuToolStripButton
            // 
            this.hakuToolStripButton.Name = "hakuToolStripButton";
            this.hakuToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // Kalenteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 761);
            this.Controls.Add(this.KalenteriPaneeli);
            this.Name = "Kalenteri";
            this.Text = "Kalenteri";
            this.Load += new System.EventHandler(this.Kalenteri_Load);
            this.KalenteriPaneeli.ResumeLayout(false);
            this.KalenteriLayoutPaneeliVaraus.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaraukset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel KalenteriPaneeli;
        private System.Windows.Forms.TableLayoutPanel KalenteriLayoutPaneeliVaraus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMokkiVaraukset;
        private System.Windows.Forms.Label lblAlku;
        private System.Windows.Forms.Label lblLoppu;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.DateTimePicker dateTimePickerAloitus;
        private System.Windows.Forms.DateTimePicker dateTimePickerLopetus;
        private VNDataset vNDataset;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private VNDatasetTableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewVaraukset;
        private System.Windows.Forms.TextBox TbHaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkimokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahvistuspvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattualkupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattuloppupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton hakuToolStripButton;
    }
}