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
            this.cbToimintaalue = new System.Windows.Forms.ComboBox();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vNDataset = new Mökinvarausjärjestelmä.VNDataset();
            this.lblToimialue = new System.Windows.Forms.Label();
            this.toimintaalueTableAdapter = new Mökinvarausjärjestelmä.VNDatasetTableAdapters.toimintaalueTableAdapter();
            this.dgvMokki = new System.Windows.Forms.DataGridView();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokki_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvaus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiTableAdapter = new Mökinvarausjärjestelmä.VNDatasetTableAdapters.mokkiTableAdapter();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.tbVarausNro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnHaeAsiakas = new System.Windows.Forms.Button();
            this.tbSahkoposti = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPuhelin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.asiakasTableAdapter = new Mökinvarausjärjestelmä.VNDatasetTableAdapters.asiakasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbToimintaalue
            // 
            this.cbToimintaalue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.toimintaalueBindingSource, "toimintaalue_id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbToimintaalue.DataSource = this.toimintaalueBindingSource;
            this.cbToimintaalue.DisplayMember = "nimi";
            this.cbToimintaalue.FormattingEnabled = true;
            this.cbToimintaalue.Location = new System.Drawing.Point(10, 41);
            this.cbToimintaalue.Name = "cbToimintaalue";
            this.cbToimintaalue.Size = new System.Drawing.Size(121, 21);
            this.cbToimintaalue.TabIndex = 0;
            this.cbToimintaalue.ValueMember = "toimintaalue_id";
            this.cbToimintaalue.Leave += new System.EventHandler(this.cbToimintaalue_Leave);
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
            this.lblToimialue.Location = new System.Drawing.Point(6, 18);
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
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.mokki_id,
            this.mokkinimi,
            this.postinro,
            this.katuosoite,
            this.henkilomaara,
            this.kuvaus});
            this.dgvMokki.DataSource = this.mokkiBindingSource;
            this.dgvMokki.Location = new System.Drawing.Point(11, 69);
            this.dgvMokki.Name = "dgvMokki";
            this.dgvMokki.Size = new System.Drawing.Size(644, 150);
            this.dgvMokki.TabIndex = 2;
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            // 
            // mokki_id
            // 
            this.mokki_id.DataPropertyName = "mokki_id";
            this.mokki_id.HeaderText = "mokki_id";
            this.mokki_id.Name = "mokki_id";
            // 
            // mokkinimi
            // 
            this.mokkinimi.DataPropertyName = "mokkinimi";
            this.mokkinimi.HeaderText = "mokkinimi";
            this.mokkinimi.Name = "mokkinimi";
            // 
            // postinro
            // 
            this.postinro.DataPropertyName = "postinro";
            this.postinro.HeaderText = "postinro";
            this.postinro.Name = "postinro";
            // 
            // katuosoite
            // 
            this.katuosoite.DataPropertyName = "katuosoite";
            this.katuosoite.HeaderText = "katuosoite";
            this.katuosoite.Name = "katuosoite";
            // 
            // henkilomaara
            // 
            this.henkilomaara.DataPropertyName = "henkilomaara";
            this.henkilomaara.HeaderText = "henkilomaara";
            this.henkilomaara.Name = "henkilomaara";
            // 
            // kuvaus
            // 
            this.kuvaus.DataPropertyName = "kuvaus";
            this.kuvaus.HeaderText = "kuvaus";
            this.kuvaus.Name = "kuvaus";
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
            this.tbVarausNro.Location = new System.Drawing.Point(10, 39);
            this.tbVarausNro.Name = "tbVarausNro";
            this.tbVarausNro.Size = new System.Drawing.Size(100, 20);
            this.tbVarausNro.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Varaus nro.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Asiakasnro";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.asiakasBindingSource;
            this.comboBox1.DisplayMember = "asiakas_id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "asiakas_id";
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.vNDataset;
            // 
            // dtpAlkupvm
            // 
            this.dtpAlkupvm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlkupvm.Location = new System.Drawing.Point(236, 41);
            this.dtpAlkupvm.Name = "dtpAlkupvm";
            this.dtpAlkupvm.Size = new System.Drawing.Size(120, 20);
            this.dtpAlkupvm.TabIndex = 8;
            // 
            // dtpLoppupvm
            // 
            this.dtpLoppupvm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLoppupvm.Location = new System.Drawing.Point(371, 41);
            this.dtpLoppupvm.Name = "dtpLoppupvm";
            this.dtpLoppupvm.Size = new System.Drawing.Size(120, 20);
            this.dtpLoppupvm.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(235, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alku pvm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(367, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loppu pvm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Palvelut";
            // 
            // clbPalvelut
            // 
            this.clbPalvelut.FormattingEnabled = true;
            this.clbPalvelut.Location = new System.Drawing.Point(16, 254);
            this.clbPalvelut.Name = "clbPalvelut";
            this.clbPalvelut.Size = new System.Drawing.Size(186, 154);
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
            this.label6.Location = new System.Drawing.Point(348, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Vahvistus pvm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(211, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Varaus pvm";
            // 
            // dtpVahvistus
            // 
            this.dtpVahvistus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVahvistus.Location = new System.Drawing.Point(352, 39);
            this.dtpVahvistus.Name = "dtpVahvistus";
            this.dtpVahvistus.Size = new System.Drawing.Size(120, 20);
            this.dtpVahvistus.TabIndex = 17;
            // 
            // dtpVarauspvm
            // 
            this.dtpVarauspvm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVarauspvm.Location = new System.Drawing.Point(212, 39);
            this.dtpVarauspvm.Name = "dtpVarauspvm";
            this.dtpVarauspvm.Size = new System.Drawing.Size(120, 20);
            this.dtpVarauspvm.TabIndex = 16;
            // 
            // btnHae
            // 
            this.btnHae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnHae.Location = new System.Drawing.Point(116, 39);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(75, 20);
            this.btnHae.TabIndex = 20;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnHae);
            this.groupBox1.Controls.Add(this.tbVarausNro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpVarauspvm);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpVahvistus);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 81);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Varaus";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHaeAsiakas);
            this.groupBox2.Controls.Add(this.tbSahkoposti);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbPuhelin);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbLahiosoite);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbSukunimi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbPostinumero);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbEtunimi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 171);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asiakastiedot";
            // 
            // btnHaeAsiakas
            // 
            this.btnHaeAsiakas.Location = new System.Drawing.Point(10, 67);
            this.btnHaeAsiakas.Name = "btnHaeAsiakas";
            this.btnHaeAsiakas.Size = new System.Drawing.Size(121, 23);
            this.btnHaeAsiakas.TabIndex = 20;
            this.btnHaeAsiakas.Text = "Hae";
            this.btnHaeAsiakas.UseVisualStyleBackColor = true;
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "email", true));
            this.tbSahkoposti.Location = new System.Drawing.Point(281, 131);
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(177, 20);
            this.tbSahkoposti.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label13.Location = new System.Drawing.Point(277, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Sähköposti";
            // 
            // tbPuhelin
            // 
            this.tbPuhelin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "puhelinnro", true));
            this.tbPuhelin.Location = new System.Drawing.Point(156, 131);
            this.tbPuhelin.Name = "tbPuhelin";
            this.tbPuhelin.Size = new System.Drawing.Size(115, 20);
            this.tbPuhelin.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label12.Location = new System.Drawing.Point(152, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Puhelin";
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "lahiosoite", true));
            this.tbLahiosoite.Location = new System.Drawing.Point(281, 85);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(177, 20);
            this.tbLahiosoite.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.Location = new System.Drawing.Point(277, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Lähiosoite";
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "sukunimi", true));
            this.tbSukunimi.Location = new System.Drawing.Point(281, 39);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(115, 20);
            this.tbSukunimi.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(277, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Sukunimi";
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "postinro", true));
            this.tbPostinumero.Location = new System.Drawing.Point(156, 85);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(115, 20);
            this.tbPostinumero.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.Location = new System.Drawing.Point(152, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Postinumero";
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "etunimi", true));
            this.tbEtunimi.Location = new System.Drawing.Point(156, 39);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(115, 20);
            this.tbEtunimi.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.Location = new System.Drawing.Point(152, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Etunimi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbToimintaalue);
            this.groupBox3.Controls.Add(this.lblToimialue);
            this.groupBox3.Controls.Add(this.dgvMokki);
            this.groupBox3.Controls.Add(this.clbPalvelut);
            this.groupBox3.Controls.Add(this.dtpAlkupvm);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtpLoppupvm);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(11, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(761, 424);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mökkitiedot";
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // Varaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.groupBox3);
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
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbToimintaalue;
        private System.Windows.Forms.Label lblToimialue;
        private VNDataset vNDataset;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private VNDatasetTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private System.Windows.Forms.DataGridView dgvMokki;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private VNDatasetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
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
        private System.Windows.Forms.TextBox tbSahkoposti;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPuhelin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokki_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinro;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoite;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaara;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvaus;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private VNDatasetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.Button btnHaeAsiakas;
    }
}