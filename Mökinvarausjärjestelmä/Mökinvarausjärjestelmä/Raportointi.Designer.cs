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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tcontrolRaportit = new System.Windows.Forms.TabControl();
            this.PageMajoitukset = new System.Windows.Forms.TabPage();
            this.PagePalvelut = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAlku = new System.Windows.Forms.Label();
            this.lblLoppu = new System.Windows.Forms.Label();
            this.dateTimePickerAloitus = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLopetus = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ToimialueSelect = new System.Windows.Forms.ComboBox();
            this.chartMajoitukset = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tcontrolRaportit.SuspendLayout();
            this.PageMajoitukset.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMajoitukset)).BeginInit();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 130);
            this.panel2.TabIndex = 0;
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
            this.PageMajoitukset.Controls.Add(this.chartMajoitukset);
            this.PageMajoitukset.Location = new System.Drawing.Point(4, 29);
            this.PageMajoitukset.Name = "PageMajoitukset";
            this.PageMajoitukset.Padding = new System.Windows.Forms.Padding(3);
            this.PageMajoitukset.Size = new System.Drawing.Size(752, 568);
            this.PageMajoitukset.TabIndex = 0;
            this.PageMajoitukset.Text = "Majoitukset";
            this.PageMajoitukset.UseVisualStyleBackColor = true;
            // 
            // PagePalvelut
            // 
            this.PagePalvelut.Location = new System.Drawing.Point(4, 29);
            this.PagePalvelut.Name = "PagePalvelut";
            this.PagePalvelut.Padding = new System.Windows.Forms.Padding(3);
            this.PagePalvelut.Size = new System.Drawing.Size(752, 568);
            this.PagePalvelut.TabIndex = 1;
            this.PagePalvelut.Text = "Palvelut";
            this.PagePalvelut.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Controls.Add(this.ToimialueSelect, 2, 1);
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
            // dateTimePickerAloitus
            // 
            this.dateTimePickerAloitus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerAloitus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAloitus.Location = new System.Drawing.Point(100, 8);
            this.dateTimePickerAloitus.Name = "dateTimePickerAloitus";
            this.dateTimePickerAloitus.Size = new System.Drawing.Size(276, 26);
            this.dateTimePickerAloitus.TabIndex = 5;
            // 
            // dateTimePickerLopetus
            // 
            this.dateTimePickerLopetus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerLopetus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerLopetus.Location = new System.Drawing.Point(100, 57);
            this.dateTimePickerLopetus.Name = "dateTimePickerLopetus";
            this.dateTimePickerLopetus.Size = new System.Drawing.Size(276, 26);
            this.dateTimePickerLopetus.TabIndex = 6;
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
            // ToimialueSelect
            // 
            this.ToimialueSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ToimialueSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ToimialueSelect.FormattingEnabled = true;
            this.ToimialueSelect.Items.AddRange(new object[] {
            "Ruka",
            "Ylläs",
            "Tahko"});
            this.ToimialueSelect.Location = new System.Drawing.Point(480, 46);
            this.ToimialueSelect.Name = "ToimialueSelect";
            this.ToimialueSelect.Size = new System.Drawing.Size(245, 28);
            this.ToimialueSelect.TabIndex = 9;
            this.ToimialueSelect.Text = "Toimialue";
            // 
            // chartMajoitukset
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMajoitukset.ChartAreas.Add(chartArea2);
            this.chartMajoitukset.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Name = "Legend1";
            this.chartMajoitukset.Legends.Add(legend2);
            this.chartMajoitukset.Location = new System.Drawing.Point(170, 149);
            this.chartMajoitukset.Name = "chartMajoitukset";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMajoitukset.Series.Add(series2);
            this.chartMajoitukset.Size = new System.Drawing.Size(300, 300);
            this.chartMajoitukset.TabIndex = 0;
            this.chartMajoitukset.Text = "Majoitukset";
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tcontrolRaportit.ResumeLayout(false);
            this.PageMajoitukset.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMajoitukset)).EndInit();
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
        private System.Windows.Forms.ComboBox ToimialueSelect;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMajoitukset;
    }
}