namespace Mökinvarausjärjestelmä
{
    partial class Varaus
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
            this.cbToimialue = new System.Windows.Forms.ComboBox();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vNDataset = new Mökinvarausjärjestelmä.VNDataset();
            this.lblToimialue = new System.Windows.Forms.Label();
            this.toimintaalueTableAdapter = new Mökinvarausjärjestelmä.VNDatasetTableAdapters.toimintaalueTableAdapter();
            this.dgvMokki = new System.Windows.Forms.DataGridView();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiTableAdapter = new Mökinvarausjärjestelmä.VNDatasetTableAdapters.mokkiTableAdapter();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.tbVarausNro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpAlkupvm = new System.Windows.Forms.DateTimePicker();
            this.dtpLoppupvm = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clbPalvelut = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpVahvistus = new System.Windows.Forms.DateTimePicker();
            this.dtpVarauspvm = new System.Windows.Forms.DateTimePicker();
            this.btnHae = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.Etunimi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPostinr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSahkoposti = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPuhelin = new System.Windows.Forms.TextBox();
            this.Mokkitiedot = new System.Windows.Forms.GroupBox();
            this.btnHaeMokki = new System.Windows.Forms.Button();
            this.btnHaeAsiakas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Mokkitiedot.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbToimialue
            // 
            this.cbToimialue.DataSource = this.toimintaalueBindingSource;
            this.cbToimialue.DisplayMember = "nimi";
            this.cbToimialue.FormattingEnabled = true;
            this.cbToimialue.Location = new System.Drawing.Point(21, 44);
            this.cbToimialue.Name = "cbToimialue";
            this.cbToimialue.Size = new System.Drawing.Size(121, 21);
            this.cbToimialue.TabIndex = 0;
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
            // lblToimialue
            // 
            this.lblToimialue.AutoSize = true;
            this.lblToimialue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblToimialue.Location = new System.Drawing.Point(17, 21);
            this.lblToimialue.Name = "lblToimialue";
            this.lblToimialue.Size = new System.Drawing.Size(99, 20);
            this.lblToimialue.TabIndex = 1;
            this.lblToimialue.Text = "Toimintaalue";
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // dgvMokki
            // 
            this.dgvMokki.AutoGenerateColumns = false;
            this.dgvMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.dgvMokki.DataSource = this.mokkiBindingSource;
            this.dgvMokki.Location = new System.Drawing.Point(21, 71);
            this.dgvMokki.Name = "dgvMokki";
            this.dgvMokki.Size = new System.Drawing.Size(644, 150);
            this.dgvMokki.TabIndex = 2;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            // 
            // varusteluDataGridViewTextBoxColumn
            // 
            this.varusteluDataGridViewTextBoxColumn.DataPropertyName = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.HeaderText = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.Name = "varusteluDataGridViewTextBoxColumn";
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.vNDataset;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnTallenna.Location = new System.Drawing.Point(667, 706);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(105, 30);
            this.btnTallenna.TabIndex = 3;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            // 
            // tbVarausNro
            // 
            this.tbVarausNro.Location = new System.Drawing.Point(15, 40);
            this.tbVarausNro.Name = "tbVarausNro";
            this.tbVarausNro.Size = new System.Drawing.Size(100, 20);
            this.tbVarausNro.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Varaus nro.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Asiakastunnus";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // dtpAlkupvm
            // 
            this.dtpAlkupvm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlkupvm.Location = new System.Drawing.Point(159, 44);
            this.dtpAlkupvm.Name = "dtpAlkupvm";
            this.dtpAlkupvm.Size = new System.Drawing.Size(120, 20);
            this.dtpAlkupvm.TabIndex = 8;
            // 
            // dtpLoppupvm
            // 
            this.dtpLoppupvm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLoppupvm.Location = new System.Drawing.Point(299, 44);
            this.dtpLoppupvm.Name = "dtpLoppupvm";
            this.dtpLoppupvm.Size = new System.Drawing.Size(120, 20);
            this.dtpLoppupvm.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(158, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alku pvm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(295, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loppu pvm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(17, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Palvelut";
            // 
            // clbPalvelut
            // 
            this.clbPalvelut.FormattingEnabled = true;
            this.clbPalvelut.Location = new System.Drawing.Point(21, 262);
            this.clbPalvelut.Name = "clbPalvelut";
            this.clbPalvelut.Size = new System.Drawing.Size(187, 139);
            this.clbPalvelut.TabIndex = 14;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(342, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Vahvistus pvm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(205, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Varaus pvm";
            // 
            // dtpVahvistus
            // 
            this.dtpVahvistus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVahvistus.Location = new System.Drawing.Point(346, 40);
            this.dtpVahvistus.Name = "dtpVahvistus";
            this.dtpVahvistus.Size = new System.Drawing.Size(120, 20);
            this.dtpVahvistus.TabIndex = 17;
            // 
            // dtpVarauspvm
            // 
            this.dtpVarauspvm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVarauspvm.Location = new System.Drawing.Point(206, 40);
            this.dtpVarauspvm.Name = "dtpVarauspvm";
            this.dtpVarauspvm.Size = new System.Drawing.Size(120, 20);
            this.dtpVarauspvm.TabIndex = 16;
            // 
            // btnHae
            // 
            this.btnHae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnHae.Location = new System.Drawing.Point(124, 40);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(75, 20);
            this.btnHae.TabIndex = 20;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbVarausNro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnHae);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpVahvistus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpVarauspvm);
            this.groupBox1.Location = new System.Drawing.Point(15, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 83);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Varaus";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHaeAsiakas);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbSahkoposti);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbPuhelin);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbLahiosoite);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbPostinr);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbSukunimi);
            this.groupBox2.Controls.Add(this.Etunimi);
            this.groupBox2.Controls.Add(this.tbEtunimi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(15, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 167);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asiakastiedot";
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(148, 40);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(121, 20);
            this.tbEtunimi.TabIndex = 8;
            // 
            // Etunimi
            // 
            this.Etunimi.AutoSize = true;
            this.Etunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Etunimi.Location = new System.Drawing.Point(147, 17);
            this.Etunimi.Name = "Etunimi";
            this.Etunimi.Size = new System.Drawing.Size(62, 20);
            this.Etunimi.TabIndex = 9;
            this.Etunimi.Text = "Etunimi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.Location = new System.Drawing.Point(273, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sukunimi";
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(277, 39);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(121, 20);
            this.tbSukunimi.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.Location = new System.Drawing.Point(273, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Lähiosoite";
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(277, 85);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(178, 20);
            this.tbLahiosoite.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(142, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Postinumero";
            // 
            // tbPostinr
            // 
            this.tbPostinr.Location = new System.Drawing.Point(146, 85);
            this.tbPostinr.Name = "tbPostinr";
            this.tbPostinr.Size = new System.Drawing.Size(121, 20);
            this.tbPostinr.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.Location = new System.Drawing.Point(273, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Sähköposti";
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.Location = new System.Drawing.Point(277, 131);
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(178, 20);
            this.tbSahkoposti.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label12.Location = new System.Drawing.Point(142, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Puhelinnumero";
            // 
            // tbPuhelin
            // 
            this.tbPuhelin.Location = new System.Drawing.Point(146, 131);
            this.tbPuhelin.Name = "tbPuhelin";
            this.tbPuhelin.Size = new System.Drawing.Size(121, 20);
            this.tbPuhelin.TabIndex = 16;
            // 
            // Mokkitiedot
            // 
            this.Mokkitiedot.Controls.Add(this.btnHaeMokki);
            this.Mokkitiedot.Controls.Add(this.lblToimialue);
            this.Mokkitiedot.Controls.Add(this.cbToimialue);
            this.Mokkitiedot.Controls.Add(this.dgvMokki);
            this.Mokkitiedot.Controls.Add(this.dtpAlkupvm);
            this.Mokkitiedot.Controls.Add(this.clbPalvelut);
            this.Mokkitiedot.Controls.Add(this.dtpLoppupvm);
            this.Mokkitiedot.Controls.Add(this.label5);
            this.Mokkitiedot.Controls.Add(this.label3);
            this.Mokkitiedot.Controls.Add(this.label4);
            this.Mokkitiedot.Location = new System.Drawing.Point(15, 281);
            this.Mokkitiedot.Name = "Mokkitiedot";
            this.Mokkitiedot.Size = new System.Drawing.Size(757, 419);
            this.Mokkitiedot.TabIndex = 23;
            this.Mokkitiedot.TabStop = false;
            this.Mokkitiedot.Text = "Mokkitiedot";
            // 
            // btnHaeMokki
            // 
            this.btnHaeMokki.Location = new System.Drawing.Point(439, 41);
            this.btnHaeMokki.Name = "btnHaeMokki";
            this.btnHaeMokki.Size = new System.Drawing.Size(75, 23);
            this.btnHaeMokki.TabIndex = 15;
            this.btnHaeMokki.Text = "Hae";
            this.btnHaeMokki.UseVisualStyleBackColor = true;
            // 
            // btnHaeAsiakas
            // 
            this.btnHaeAsiakas.Location = new System.Drawing.Point(17, 67);
            this.btnHaeAsiakas.Name = "btnHaeAsiakas";
            this.btnHaeAsiakas.Size = new System.Drawing.Size(121, 23);
            this.btnHaeAsiakas.TabIndex = 20;
            this.btnHaeAsiakas.Text = "Hae";
            this.btnHaeAsiakas.UseVisualStyleBackColor = true;
            // 
            // Varaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.Mokkitiedot);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnTallenna);
            this.Name = "Varaus";
            this.Text = "VN Varaus";
            this.Load += new System.EventHandler(this.Varaus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Mokkitiedot.ResumeLayout(false);
            this.Mokkitiedot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbToimialue;
        private System.Windows.Forms.Label lblToimialue;
        private VNDataset vNDataset;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private VNDatasetTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private System.Windows.Forms.DataGridView dgvMokki;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private VNDatasetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.TextBox tbVarausNro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtpAlkupvm;
        private System.Windows.Forms.DateTimePicker dtpLoppupvm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox clbPalvelut;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpVahvistus;
        private System.Windows.Forms.DateTimePicker dtpVarauspvm;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSahkoposti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPuhelin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPostinr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.Label Etunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.GroupBox Mokkitiedot;
        private System.Windows.Forms.Button btnHaeMokki;
        private System.Windows.Forms.Button btnHaeAsiakas;
    }
}