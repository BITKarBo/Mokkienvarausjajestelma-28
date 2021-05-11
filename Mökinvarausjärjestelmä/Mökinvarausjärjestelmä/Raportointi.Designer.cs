namespace Mökinvarausjärjestelmä
{
    partial class Raportointi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tcontrolRaportit = new System.Windows.Forms.TabControl();
            this.PageMajoitukset = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chartMajoitukset = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PagePalvelut = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPylväs = new System.Windows.Forms.Button();
            this.btn3D = new System.Windows.Forms.Button();
            this.btnPiirakka = new System.Windows.Forms.Button();
            this.chartPalvelut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerLopetus = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoppu = new System.Windows.Forms.Label();
            this.lblAlku = new System.Windows.Forms.Label();
            this.dateTimePickerAloitus = new System.Windows.Forms.DateTimePicker();
            this.cbToimintaalue = new System.Windows.Forms.ComboBox();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vNDataset = new Mökinvarausjärjestelmä.VNDataset();
            this.btnupdate = new System.Windows.Forms.Button();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausTableAdapter = new Mökinvarausjärjestelmä.VNDatasetTableAdapters.varausTableAdapter();
            this.toimintaalueTableAdapter = new Mökinvarausjärjestelmä.VNDatasetTableAdapters.toimintaalueTableAdapter();
            this.varausBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblvaraukset = new System.Windows.Forms.Label();
            this.lblPalveluidenmaara = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tcontrolRaportit.SuspendLayout();
            this.PageMajoitukset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMajoitukset)).BeginInit();
            this.PagePalvelut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPalvelut)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 761);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tcontrolRaportit);
            this.panel3.Location = new System.Drawing.Point(12, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 601);
            this.panel3.TabIndex = 1;
            // 
            // tcontrolRaportit
            // 
            this.tcontrolRaportit.Controls.Add(this.PageMajoitukset);
            this.tcontrolRaportit.Controls.Add(this.PagePalvelut);
            this.tcontrolRaportit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcontrolRaportit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcontrolRaportit.Location = new System.Drawing.Point(0, 0);
            this.tcontrolRaportit.Name = "tcontrolRaportit";
            this.tcontrolRaportit.SelectedIndex = 0;
            this.tcontrolRaportit.Size = new System.Drawing.Size(760, 601);
            this.tcontrolRaportit.TabIndex = 0;
            // 
            // PageMajoitukset
            // 
            this.PageMajoitukset.Controls.Add(this.lblvaraukset);
            this.PageMajoitukset.Controls.Add(this.label2);
            this.PageMajoitukset.Controls.Add(this.button1);
            this.PageMajoitukset.Controls.Add(this.button2);
            this.PageMajoitukset.Controls.Add(this.button3);
            this.PageMajoitukset.Controls.Add(this.chartMajoitukset);
            this.PageMajoitukset.Location = new System.Drawing.Point(4, 29);
            this.PageMajoitukset.Name = "PageMajoitukset";
            this.PageMajoitukset.Padding = new System.Windows.Forms.Padding(3);
            this.PageMajoitukset.Size = new System.Drawing.Size(752, 568);
            this.PageMajoitukset.TabIndex = 0;
            this.PageMajoitukset.Text = "Majoitukset";
            this.PageMajoitukset.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vaihda Diagrammia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pylväs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPylväs_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(537, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Pyrämidi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn3D_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Piirakka";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnPiirakka_Click);
            // 
            // chartMajoitukset
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMajoitukset.ChartAreas.Add(chartArea1);
            this.chartMajoitukset.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartMajoitukset.Legends.Add(legend1);
            this.chartMajoitukset.Location = new System.Drawing.Point(6, 6);
            this.chartMajoitukset.Name = "chartMajoitukset";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Majoitukset";
            this.chartMajoitukset.Series.Add(series1);
            this.chartMajoitukset.Size = new System.Drawing.Size(366, 556);
            this.chartMajoitukset.TabIndex = 0;
            this.chartMajoitukset.Text = "Majoitukset";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "TitleMajoitus";
            title1.Text = "Raportti Majoituksista";
            this.chartMajoitukset.Titles.Add(title1);
            // 
            // PagePalvelut
            // 
            this.PagePalvelut.Controls.Add(this.lblPalveluidenmaara);
            this.PagePalvelut.Controls.Add(this.label3);
            this.PagePalvelut.Controls.Add(this.btnPylväs);
            this.PagePalvelut.Controls.Add(this.btn3D);
            this.PagePalvelut.Controls.Add(this.btnPiirakka);
            this.PagePalvelut.Controls.Add(this.chartPalvelut);
            this.PagePalvelut.Location = new System.Drawing.Point(4, 29);
            this.PagePalvelut.Name = "PagePalvelut";
            this.PagePalvelut.Padding = new System.Windows.Forms.Padding(3);
            this.PagePalvelut.Size = new System.Drawing.Size(752, 568);
            this.PagePalvelut.TabIndex = 1;
            this.PagePalvelut.Text = "Palvelut";
            this.PagePalvelut.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vaihda Diagrammia";
            // 
            // btnPylväs
            // 
            this.btnPylväs.Location = new System.Drawing.Point(642, 6);
            this.btnPylväs.Name = "btnPylväs";
            this.btnPylväs.Size = new System.Drawing.Size(99, 39);
            this.btnPylväs.TabIndex = 4;
            this.btnPylväs.Text = "Pylväs";
            this.btnPylväs.UseVisualStyleBackColor = true;
            this.btnPylväs.Click += new System.EventHandler(this.btnPylväs_Click);
            // 
            // btn3D
            // 
            this.btn3D.Location = new System.Drawing.Point(537, 6);
            this.btn3D.Name = "btn3D";
            this.btn3D.Size = new System.Drawing.Size(99, 39);
            this.btn3D.TabIndex = 3;
            this.btn3D.Text = "Pyrämidi";
            this.btn3D.UseVisualStyleBackColor = true;
            this.btn3D.Click += new System.EventHandler(this.btn3D_Click);
            // 
            // btnPiirakka
            // 
            this.btnPiirakka.Location = new System.Drawing.Point(432, 6);
            this.btnPiirakka.Name = "btnPiirakka";
            this.btnPiirakka.Size = new System.Drawing.Size(99, 39);
            this.btnPiirakka.TabIndex = 2;
            this.btnPiirakka.Text = "Piirakka";
            this.btnPiirakka.UseVisualStyleBackColor = true;
            this.btnPiirakka.Click += new System.EventHandler(this.btnPiirakka_Click);
            // 
            // chartPalvelut
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPalvelut.ChartAreas.Add(chartArea2);
            this.chartPalvelut.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartPalvelut.Legends.Add(legend2);
            this.chartPalvelut.Location = new System.Drawing.Point(6, 6);
            this.chartPalvelut.Name = "chartPalvelut";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Palvelut";
            this.chartPalvelut.Series.Add(series2);
            this.chartPalvelut.Size = new System.Drawing.Size(366, 556);
            this.chartPalvelut.TabIndex = 1;
            this.chartPalvelut.Text = "Palvelut";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "TitlePalvelut";
            title2.Text = "Raportti Palveluista";
            this.chartPalvelut.Titles.Add(title2);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 130);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerLopetus, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLoppu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAlku, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerAloitus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbToimintaalue, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnupdate, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.87755F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.12245F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 130);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dateTimePickerLopetus
            // 
            this.dateTimePickerLopetus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerLopetus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerLopetus.Location = new System.Drawing.Point(100, 57);
            this.dateTimePickerLopetus.Name = "dateTimePickerLopetus";
            this.dateTimePickerLopetus.Size = new System.Drawing.Size(276, 26);
            this.dateTimePickerLopetus.TabIndex = 6;
            this.dateTimePickerLopetus.Value = new System.DateTime(2022, 5, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Toimialue";
            // 
            // lblLoppu
            // 
            this.lblLoppu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoppu.AutoSize = true;
            this.lblLoppu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoppu.Location = new System.Drawing.Point(21, 60);
            this.lblLoppu.Name = "lblLoppu";
            this.lblLoppu.Size = new System.Drawing.Size(54, 20);
            this.lblLoppu.TabIndex = 3;
            this.lblLoppu.Text = "Loppu";
            // 
            // lblAlku
            // 
            this.lblAlku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlku.AutoSize = true;
            this.lblAlku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlku.Location = new System.Drawing.Point(28, 11);
            this.lblAlku.Name = "lblAlku";
            this.lblAlku.Size = new System.Drawing.Size(40, 20);
            this.lblAlku.TabIndex = 2;
            this.lblAlku.Text = "Alku";
            // 
            // dateTimePickerAloitus
            // 
            this.dateTimePickerAloitus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerAloitus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAloitus.Location = new System.Drawing.Point(100, 8);
            this.dateTimePickerAloitus.Name = "dateTimePickerAloitus";
            this.dateTimePickerAloitus.Size = new System.Drawing.Size(276, 26);
            this.dateTimePickerAloitus.TabIndex = 5;
            this.dateTimePickerAloitus.Value = new System.DateTime(2015, 5, 11, 17, 13, 0, 0);
            // 
            // cbToimintaalue
            // 
            this.cbToimintaalue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.toimintaalueBindingSource, "toimintaalue_id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbToimintaalue.DataSource = this.toimintaalueBindingSource;
            this.cbToimintaalue.DisplayMember = "nimi";
            this.cbToimintaalue.FormattingEnabled = true;
            this.cbToimintaalue.Location = new System.Drawing.Point(448, 46);
            this.cbToimintaalue.Name = "cbToimintaalue";
            this.cbToimintaalue.Size = new System.Drawing.Size(308, 21);
            this.cbToimintaalue.TabIndex = 9;
            this.cbToimintaalue.ValueMember = "toimintaalue_id";
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
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(448, 101);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Päivitä";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.vNDataset;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // varausBindingSource1
            // 
            this.varausBindingSource1.DataMember = "varaus";
            this.varausBindingSource1.DataSource = this.vNDataset;
            // 
            // lblvaraukset
            // 
            this.lblvaraukset.AutoSize = true;
            this.lblvaraukset.Location = new System.Drawing.Point(432, 128);
            this.lblvaraukset.Name = "lblvaraukset";
            this.lblvaraukset.Size = new System.Drawing.Size(140, 20);
            this.lblvaraukset.TabIndex = 9;
            this.lblvaraukset.Text = "Varausten Määrä: ";
            // 
            // lblPalveluidenmaara
            // 
            this.lblPalveluidenmaara.AutoSize = true;
            this.lblPalveluidenmaara.Location = new System.Drawing.Point(428, 134);
            this.lblPalveluidenmaara.Name = "lblPalveluidenmaara";
            this.lblPalveluidenmaara.Size = new System.Drawing.Size(140, 20);
            this.lblPalveluidenmaara.TabIndex = 10;
            this.lblPalveluidenmaara.Text = "Varausten Määrä: ";
            // 
            // Raportointi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "Raportointi";
            this.Text = "Raportointi";
            this.Load += new System.EventHandler(this.Raportointi_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tcontrolRaportit.ResumeLayout(false);
            this.PageMajoitukset.ResumeLayout(false);
            this.PageMajoitukset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMajoitukset)).EndInit();
            this.PagePalvelut.ResumeLayout(false);
            this.PagePalvelut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPalvelut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tcontrolRaportit;
        private System.Windows.Forms.TabPage PageMajoitukset;
        private System.Windows.Forms.TabPage PagePalvelut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAlku;
        private System.Windows.Forms.Label lblLoppu;
        private System.Windows.Forms.DateTimePicker dateTimePickerAloitus;
        private System.Windows.Forms.DateTimePicker dateTimePickerLopetus;
        private System.Windows.Forms.Label label1;
        private VNDataset vNDataset;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private VNDatasetTableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private VNDatasetTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private System.Windows.Forms.ComboBox cbToimintaalue;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMajoitukset;
        private System.Windows.Forms.BindingSource varausBindingSource1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPalvelut;
        private System.Windows.Forms.Button btnPylväs;
        private System.Windows.Forms.Button btn3D;
        private System.Windows.Forms.Button btnPiirakka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblvaraukset;
        private System.Windows.Forms.Label lblPalveluidenmaara;
    }
}