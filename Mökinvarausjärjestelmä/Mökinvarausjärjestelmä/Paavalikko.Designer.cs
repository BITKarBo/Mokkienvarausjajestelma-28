namespace Mökinvarausjärjestelmä
{
    partial class Paavalikko
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
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vNDataset = new Mökinvarausjärjestelmä.VNDataset();
            this.btnUusiVaraus = new System.Windows.Forms.Button();
            this.btnKalenteri = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnRaportti = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toimintaalueTableAdapter = new Mökinvarausjärjestelmä.VNDatasetTableAdapters.toimintaalueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNDataset)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.vNDataset;
            // 
            // vNDataset
            // 
            this.vNDataset.DataSetName = "VNDataset";
            this.vNDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUusiVaraus
            // 
            this.btnUusiVaraus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUusiVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnUusiVaraus.Location = new System.Drawing.Point(232, 174);
            this.btnUusiVaraus.Name = "btnUusiVaraus";
            this.btnUusiVaraus.Size = new System.Drawing.Size(301, 99);
            this.btnUusiVaraus.TabIndex = 1;
            this.btnUusiVaraus.Text = "Uusi varaus";
            this.btnUusiVaraus.UseVisualStyleBackColor = true;
            this.btnUusiVaraus.Click += new System.EventHandler(this.btnUusiVaraus_Click);
            // 
            // btnKalenteri
            // 
            this.btnKalenteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKalenteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnKalenteri.Location = new System.Drawing.Point(232, 279);
            this.btnKalenteri.Name = "btnKalenteri";
            this.btnKalenteri.Size = new System.Drawing.Size(301, 75);
            this.btnKalenteri.TabIndex = 2;
            this.btnKalenteri.Text = "Varaus kalenteri";
            this.btnKalenteri.UseVisualStyleBackColor = true;
            this.btnKalenteri.Click += new System.EventHandler(this.btnKalenteri_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMuokkaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMuokkaa.Location = new System.Drawing.Point(232, 433);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(301, 65);
            this.btnMuokkaa.TabIndex = 4;
            this.btnMuokkaa.Text = "Muokkaa / Lisää";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnRaportti
            // 
            this.btnRaportti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRaportti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRaportti.Location = new System.Drawing.Point(232, 360);
            this.btnRaportti.Name = "btnRaportti";
            this.btnRaportti.Size = new System.Drawing.Size(301, 67);
            this.btnRaportti.TabIndex = 3;
            this.btnRaportti.Text = "Raportointi";
            this.btnRaportti.UseVisualStyleBackColor = true;
            this.btnRaportti.Click += new System.EventHandler(this.btnRaportti_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnUusiVaraus, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMuokkaa, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnRaportti, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnKalenteri, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 761);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // Paavalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Paavalikko";
            this.Text = "Paavalikko";
            this.Load += new System.EventHandler(this.Paavalikko_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNDataset)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUusiVaraus;
        private System.Windows.Forms.Button btnKalenteri;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnRaportti;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private VNDataset vNDataset;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private VNDatasetTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
    }
}