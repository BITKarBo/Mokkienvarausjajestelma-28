namespace Mökinvarausjärjestelmä
{
    partial class Muokkaa
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
            this.Mökit = new System.Windows.Forms.TabControl();
            this.Mokit = new System.Windows.Forms.TabPage();
            this.tbMokinHinta = new System.Windows.Forms.TextBox();
            this.lblMokinHinta = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbMokinNimi = new System.Windows.Forms.TextBox();
            this.tbMokinOsoite = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxOminaisuudet = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLisaaMokki = new System.Windows.Forms.Button();
            this.lblMajoituspaikat = new System.Windows.Forms.Label();
            this.lblToimialue = new System.Windows.Forms.Label();
            this.lblOsoite = new System.Windows.Forms.Label();
            this.lblMokinNimi = new System.Windows.Forms.Label();
            this.Palvelut = new System.Windows.Forms.TabPage();
            this.groupBoxPalvelut = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPalvelunKuvaus = new System.Windows.Forms.Label();
            this.lblPalvelunHinta = new System.Windows.Forms.Label();
            this.lblPalvelunNimi = new System.Windows.Forms.Label();
            this.btnPoistaPalvelu = new System.Windows.Forms.Button();
            this.btnLisaaPalvelu = new System.Windows.Forms.Button();
            this.Asiakkaat = new System.Windows.Forms.TabPage();
            this.tbAsiakasnumero = new System.Windows.Forms.TextBox();
            this.lblAsiakasnumero = new System.Windows.Forms.Label();
            this.btnPoistaAsiakas = new System.Windows.Forms.Button();
            this.btnLisaaAsiakas = new System.Windows.Forms.Button();
            this.tbSposti = new System.Windows.Forms.TextBox();
            this.lblSposti = new System.Windows.Forms.Label();
            this.tbAsiakkaanPuhNum = new System.Windows.Forms.TextBox();
            this.tbAsiakkaanOsoite = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblPuhNum = new System.Windows.Forms.Label();
            this.lblAsiakkaanOsoite = new System.Windows.Forms.Label();
            this.lblAsiakkaanNimi = new System.Windows.Forms.Label();
            this.Laskut = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLasku = new System.Windows.Forms.Label();
            this.Mökit.SuspendLayout();
            this.Mokit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Palvelut.SuspendLayout();
            this.Asiakkaat.SuspendLayout();
            this.Laskut.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mökit
            // 
            this.Mökit.Controls.Add(this.Mokit);
            this.Mökit.Controls.Add(this.Palvelut);
            this.Mökit.Controls.Add(this.Asiakkaat);
            this.Mökit.Controls.Add(this.Laskut);
            this.Mökit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mökit.Location = new System.Drawing.Point(0, 0);
            this.Mökit.Name = "Mökit";
            this.Mökit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mökit.SelectedIndex = 0;
            this.Mökit.Size = new System.Drawing.Size(785, 765);
            this.Mökit.TabIndex = 0;
            // 
            // Mokit
            // 
            this.Mokit.Controls.Add(this.tbMokinHinta);
            this.Mokit.Controls.Add(this.lblMokinHinta);
            this.Mokit.Controls.Add(this.button2);
            this.Mokit.Controls.Add(this.button1);
            this.Mokit.Controls.Add(this.tbMokinNimi);
            this.Mokit.Controls.Add(this.tbMokinOsoite);
            this.Mokit.Controls.Add(this.comboBox1);
            this.Mokit.Controls.Add(this.numericUpDown1);
            this.Mokit.Controls.Add(this.checkedListBoxOminaisuudet);
            this.Mokit.Controls.Add(this.label1);
            this.Mokit.Controls.Add(this.btnLisaaMokki);
            this.Mokit.Controls.Add(this.lblMajoituspaikat);
            this.Mokit.Controls.Add(this.lblToimialue);
            this.Mokit.Controls.Add(this.lblOsoite);
            this.Mokit.Controls.Add(this.lblMokinNimi);
            this.Mokit.Location = new System.Drawing.Point(4, 22);
            this.Mokit.Name = "Mokit";
            this.Mokit.Padding = new System.Windows.Forms.Padding(3);
            this.Mokit.Size = new System.Drawing.Size(777, 739);
            this.Mokit.TabIndex = 0;
            this.Mokit.Text = "Mökit";
            this.Mokit.UseVisualStyleBackColor = true;
            // 
            // tbMokinHinta
            // 
            this.tbMokinHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMokinHinta.Location = new System.Drawing.Point(360, 558);
            this.tbMokinHinta.Name = "tbMokinHinta";
            this.tbMokinHinta.Size = new System.Drawing.Size(310, 31);
            this.tbMokinHinta.TabIndex = 15;
            // 
            // lblMokinHinta
            // 
            this.lblMokinHinta.AutoSize = true;
            this.lblMokinHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblMokinHinta.Location = new System.Drawing.Point(77, 563);
            this.lblMokinHinta.Name = "lblMokinHinta";
            this.lblMokinHinta.Size = new System.Drawing.Size(98, 26);
            this.lblMokinHinta.TabIndex = 14;
            this.lblMokinHinta.Text = "Hinta/vrk";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(520, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 77);
            this.button2.TabIndex = 13;
            this.button2.Text = "Poista mökki";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(46, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 77);
            this.button1.TabIndex = 12;
            this.button1.Text = "Hae mökki";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbMokinNimi
            // 
            this.tbMokinNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMokinNimi.Location = new System.Drawing.Point(360, 78);
            this.tbMokinNimi.Name = "tbMokinNimi";
            this.tbMokinNimi.Size = new System.Drawing.Size(311, 31);
            this.tbMokinNimi.TabIndex = 11;
            // 
            // tbMokinOsoite
            // 
            this.tbMokinOsoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMokinOsoite.Location = new System.Drawing.Point(361, 127);
            this.tbMokinOsoite.Name = "tbMokinOsoite";
            this.tbMokinOsoite.Size = new System.Drawing.Size(310, 31);
            this.tbMokinOsoite.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ruka",
            "Tahko",
            "Yllästunturi"});
            this.comboBox1.Location = new System.Drawing.Point(360, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(311, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(551, 225);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 8;
            // 
            // checkedListBoxOminaisuudet
            // 
            this.checkedListBoxOminaisuudet.FormattingEnabled = true;
            this.checkedListBoxOminaisuudet.Items.AddRange(new object[] {
            "Takka",
            "Sisävessa",
            "Keittiö",
            "Sähköt",
            "Sähkölämmitys",
            "Autopaikka",
            "Sisäsauna - Puu",
            "Sisäsauna - Sähkö",
            "Rantasauna - Puu",
            "Rantasauna - Sähkö",
            "Palju",
            "Poreamme",
            "Uimaranta",
            "Venepaikka",
            "Vene"});
            this.checkedListBoxOminaisuudet.Location = new System.Drawing.Point(361, 286);
            this.checkedListBoxOminaisuudet.Name = "checkedListBoxOminaisuudet";
            this.checkedListBoxOminaisuudet.Size = new System.Drawing.Size(310, 229);
            this.checkedListBoxOminaisuudet.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ominaisuudet";
            // 
            // btnLisaaMokki
            // 
            this.btnLisaaMokki.BackColor = System.Drawing.Color.Transparent;
            this.btnLisaaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaMokki.Location = new System.Drawing.Point(283, 617);
            this.btnLisaaMokki.Name = "btnLisaaMokki";
            this.btnLisaaMokki.Size = new System.Drawing.Size(231, 77);
            this.btnLisaaMokki.TabIndex = 4;
            this.btnLisaaMokki.Text = "Lisää mökki";
            this.btnLisaaMokki.UseVisualStyleBackColor = false;
            // 
            // lblMajoituspaikat
            // 
            this.lblMajoituspaikat.AutoSize = true;
            this.lblMajoituspaikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajoituspaikat.Location = new System.Drawing.Point(52, 231);
            this.lblMajoituspaikat.Name = "lblMajoituspaikat";
            this.lblMajoituspaikat.Size = new System.Drawing.Size(221, 25);
            this.lblMajoituspaikat.TabIndex = 3;
            this.lblMajoituspaikat.Text = "Majoituspaikat/sängyt";
            // 
            // lblToimialue
            // 
            this.lblToimialue.AutoSize = true;
            this.lblToimialue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToimialue.Location = new System.Drawing.Point(52, 182);
            this.lblToimialue.Name = "lblToimialue";
            this.lblToimialue.Size = new System.Drawing.Size(105, 25);
            this.lblToimialue.TabIndex = 2;
            this.lblToimialue.Text = "Toimialue";
            // 
            // lblOsoite
            // 
            this.lblOsoite.AutoSize = true;
            this.lblOsoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsoite.Location = new System.Drawing.Point(52, 123);
            this.lblOsoite.Name = "lblOsoite";
            this.lblOsoite.Size = new System.Drawing.Size(74, 25);
            this.lblOsoite.TabIndex = 1;
            this.lblOsoite.Text = "Osoite";
            // 
            // lblMokinNimi
            // 
            this.lblMokinNimi.AutoSize = true;
            this.lblMokinNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokinNimi.Location = new System.Drawing.Point(52, 74);
            this.lblMokinNimi.Name = "lblMokinNimi";
            this.lblMokinNimi.Size = new System.Drawing.Size(115, 25);
            this.lblMokinNimi.TabIndex = 0;
            this.lblMokinNimi.Text = "Mökin nimi";
            // 
            // Palvelut
            // 
            this.Palvelut.Controls.Add(this.groupBoxPalvelut);
            this.Palvelut.Controls.Add(this.textBox3);
            this.Palvelut.Controls.Add(this.textBox2);
            this.Palvelut.Controls.Add(this.textBox1);
            this.Palvelut.Controls.Add(this.lblPalvelunKuvaus);
            this.Palvelut.Controls.Add(this.lblPalvelunHinta);
            this.Palvelut.Controls.Add(this.lblPalvelunNimi);
            this.Palvelut.Controls.Add(this.btnPoistaPalvelu);
            this.Palvelut.Controls.Add(this.btnLisaaPalvelu);
            this.Palvelut.Location = new System.Drawing.Point(4, 22);
            this.Palvelut.Name = "Palvelut";
            this.Palvelut.Padding = new System.Windows.Forms.Padding(3);
            this.Palvelut.Size = new System.Drawing.Size(777, 739);
            this.Palvelut.TabIndex = 1;
            this.Palvelut.Text = "Palvelut";
            this.Palvelut.UseVisualStyleBackColor = true;
            // 
            // groupBoxPalvelut
            // 
            this.groupBoxPalvelut.Location = new System.Drawing.Point(60, 286);
            this.groupBoxPalvelut.Name = "groupBoxPalvelut";
            this.groupBoxPalvelut.Size = new System.Drawing.Size(708, 346);
            this.groupBoxPalvelut.TabIndex = 23;
            this.groupBoxPalvelut.TabStop = false;
            this.groupBoxPalvelut.Text = "Palvelut";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.textBox3.Location = new System.Drawing.Point(316, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(452, 32);
            this.textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(316, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(316, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 31);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "esim. Loppusiivous";
            // 
            // lblPalvelunKuvaus
            // 
            this.lblPalvelunKuvaus.AutoSize = true;
            this.lblPalvelunKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblPalvelunKuvaus.Location = new System.Drawing.Point(55, 181);
            this.lblPalvelunKuvaus.Name = "lblPalvelunKuvaus";
            this.lblPalvelunKuvaus.Size = new System.Drawing.Size(85, 26);
            this.lblPalvelunKuvaus.TabIndex = 19;
            this.lblPalvelunKuvaus.Text = "Kuvaus";
            // 
            // lblPalvelunHinta
            // 
            this.lblPalvelunHinta.AutoSize = true;
            this.lblPalvelunHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblPalvelunHinta.Location = new System.Drawing.Point(55, 136);
            this.lblPalvelunHinta.Name = "lblPalvelunHinta";
            this.lblPalvelunHinta.Size = new System.Drawing.Size(63, 26);
            this.lblPalvelunHinta.TabIndex = 18;
            this.lblPalvelunHinta.Text = "Hinta";
            // 
            // lblPalvelunNimi
            // 
            this.lblPalvelunNimi.AutoSize = true;
            this.lblPalvelunNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblPalvelunNimi.Location = new System.Drawing.Point(55, 88);
            this.lblPalvelunNimi.Name = "lblPalvelunNimi";
            this.lblPalvelunNimi.Size = new System.Drawing.Size(143, 26);
            this.lblPalvelunNimi.TabIndex = 17;
            this.lblPalvelunNimi.Text = "Palvelun nimi";
            // 
            // btnPoistaPalvelu
            // 
            this.btnPoistaPalvelu.BackColor = System.Drawing.Color.Transparent;
            this.btnPoistaPalvelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaPalvelu.Location = new System.Drawing.Point(386, 638);
            this.btnPoistaPalvelu.Name = "btnPoistaPalvelu";
            this.btnPoistaPalvelu.Size = new System.Drawing.Size(231, 77);
            this.btnPoistaPalvelu.TabIndex = 16;
            this.btnPoistaPalvelu.Text = "Poista palvelu";
            this.btnPoistaPalvelu.UseVisualStyleBackColor = false;
            // 
            // btnLisaaPalvelu
            // 
            this.btnLisaaPalvelu.BackColor = System.Drawing.Color.Transparent;
            this.btnLisaaPalvelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaPalvelu.Location = new System.Drawing.Point(149, 638);
            this.btnLisaaPalvelu.Name = "btnLisaaPalvelu";
            this.btnLisaaPalvelu.Size = new System.Drawing.Size(231, 77);
            this.btnLisaaPalvelu.TabIndex = 14;
            this.btnLisaaPalvelu.Text = "Lisää palvelu";
            this.btnLisaaPalvelu.UseVisualStyleBackColor = false;
            // 
            // Asiakkaat
            // 
            this.Asiakkaat.Controls.Add(this.tbAsiakasnumero);
            this.Asiakkaat.Controls.Add(this.lblAsiakasnumero);
            this.Asiakkaat.Controls.Add(this.btnPoistaAsiakas);
            this.Asiakkaat.Controls.Add(this.btnLisaaAsiakas);
            this.Asiakkaat.Controls.Add(this.tbSposti);
            this.Asiakkaat.Controls.Add(this.lblSposti);
            this.Asiakkaat.Controls.Add(this.tbAsiakkaanPuhNum);
            this.Asiakkaat.Controls.Add(this.tbAsiakkaanOsoite);
            this.Asiakkaat.Controls.Add(this.textBox6);
            this.Asiakkaat.Controls.Add(this.lblPuhNum);
            this.Asiakkaat.Controls.Add(this.lblAsiakkaanOsoite);
            this.Asiakkaat.Controls.Add(this.lblAsiakkaanNimi);
            this.Asiakkaat.Location = new System.Drawing.Point(4, 22);
            this.Asiakkaat.Name = "Asiakkaat";
            this.Asiakkaat.Padding = new System.Windows.Forms.Padding(3);
            this.Asiakkaat.Size = new System.Drawing.Size(777, 739);
            this.Asiakkaat.TabIndex = 2;
            this.Asiakkaat.Text = "Asiakkaat";
            this.Asiakkaat.UseVisualStyleBackColor = true;
            // 
            // tbAsiakasnumero
            // 
            this.tbAsiakasnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.tbAsiakasnumero.Location = new System.Drawing.Point(293, 263);
            this.tbAsiakasnumero.Name = "tbAsiakasnumero";
            this.tbAsiakasnumero.Size = new System.Drawing.Size(452, 32);
            this.tbAsiakasnumero.TabIndex = 35;
            // 
            // lblAsiakasnumero
            // 
            this.lblAsiakasnumero.AutoSize = true;
            this.lblAsiakasnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblAsiakasnumero.Location = new System.Drawing.Point(32, 269);
            this.lblAsiakasnumero.Name = "lblAsiakasnumero";
            this.lblAsiakasnumero.Size = new System.Drawing.Size(163, 26);
            this.lblAsiakasnumero.TabIndex = 34;
            this.lblAsiakasnumero.Text = "Asiakasnumero";
            // 
            // btnPoistaAsiakas
            // 
            this.btnPoistaAsiakas.BackColor = System.Drawing.Color.Transparent;
            this.btnPoistaAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaAsiakas.Location = new System.Drawing.Point(357, 506);
            this.btnPoistaAsiakas.Name = "btnPoistaAsiakas";
            this.btnPoistaAsiakas.Size = new System.Drawing.Size(231, 77);
            this.btnPoistaAsiakas.TabIndex = 33;
            this.btnPoistaAsiakas.Text = "Poista asiakas";
            this.btnPoistaAsiakas.UseVisualStyleBackColor = false;
            // 
            // btnLisaaAsiakas
            // 
            this.btnLisaaAsiakas.BackColor = System.Drawing.Color.Transparent;
            this.btnLisaaAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaAsiakas.Location = new System.Drawing.Point(120, 506);
            this.btnLisaaAsiakas.Name = "btnLisaaAsiakas";
            this.btnLisaaAsiakas.Size = new System.Drawing.Size(231, 77);
            this.btnLisaaAsiakas.TabIndex = 32;
            this.btnLisaaAsiakas.Text = "Lisää asiakas";
            this.btnLisaaAsiakas.UseVisualStyleBackColor = false;
            // 
            // tbSposti
            // 
            this.tbSposti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.tbSposti.Location = new System.Drawing.Point(293, 212);
            this.tbSposti.Name = "tbSposti";
            this.tbSposti.Size = new System.Drawing.Size(452, 32);
            this.tbSposti.TabIndex = 31;
            // 
            // lblSposti
            // 
            this.lblSposti.AutoSize = true;
            this.lblSposti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblSposti.Location = new System.Drawing.Point(32, 218);
            this.lblSposti.Name = "lblSposti";
            this.lblSposti.Size = new System.Drawing.Size(120, 26);
            this.lblSposti.TabIndex = 29;
            this.lblSposti.Text = "Sähköposti";
            // 
            // tbAsiakkaanPuhNum
            // 
            this.tbAsiakkaanPuhNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.tbAsiakkaanPuhNum.Location = new System.Drawing.Point(293, 155);
            this.tbAsiakkaanPuhNum.Name = "tbAsiakkaanPuhNum";
            this.tbAsiakkaanPuhNum.Size = new System.Drawing.Size(452, 32);
            this.tbAsiakkaanPuhNum.TabIndex = 28;
            // 
            // tbAsiakkaanOsoite
            // 
            this.tbAsiakkaanOsoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAsiakkaanOsoite.Location = new System.Drawing.Point(293, 100);
            this.tbAsiakkaanOsoite.Name = "tbAsiakkaanOsoite";
            this.tbAsiakkaanOsoite.Size = new System.Drawing.Size(452, 31);
            this.tbAsiakkaanOsoite.TabIndex = 27;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(293, 52);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(452, 31);
            this.textBox6.TabIndex = 26;
            this.textBox6.Text = "esim. Loppusiivous";
            // 
            // lblPuhNum
            // 
            this.lblPuhNum.AutoSize = true;
            this.lblPuhNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblPuhNum.Location = new System.Drawing.Point(32, 161);
            this.lblPuhNum.Name = "lblPuhNum";
            this.lblPuhNum.Size = new System.Drawing.Size(159, 26);
            this.lblPuhNum.TabIndex = 25;
            this.lblPuhNum.Text = "Puhelinnumero";
            // 
            // lblAsiakkaanOsoite
            // 
            this.lblAsiakkaanOsoite.AutoSize = true;
            this.lblAsiakkaanOsoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblAsiakkaanOsoite.Location = new System.Drawing.Point(32, 105);
            this.lblAsiakkaanOsoite.Name = "lblAsiakkaanOsoite";
            this.lblAsiakkaanOsoite.Size = new System.Drawing.Size(75, 26);
            this.lblAsiakkaanOsoite.TabIndex = 24;
            this.lblAsiakkaanOsoite.Text = "Osoite";
            // 
            // lblAsiakkaanNimi
            // 
            this.lblAsiakkaanNimi.AutoSize = true;
            this.lblAsiakkaanNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblAsiakkaanNimi.Location = new System.Drawing.Point(32, 57);
            this.lblAsiakkaanNimi.Name = "lblAsiakkaanNimi";
            this.lblAsiakkaanNimi.Size = new System.Drawing.Size(164, 26);
            this.lblAsiakkaanNimi.TabIndex = 23;
            this.lblAsiakkaanNimi.Text = "Asiakkaan Nimi";
            // 
            // Laskut
            // 
            this.Laskut.Controls.Add(this.button3);
            this.Laskut.Controls.Add(this.button4);
            this.Laskut.Controls.Add(this.button5);
            this.Laskut.Controls.Add(this.textBox8);
            this.Laskut.Controls.Add(this.textBox7);
            this.Laskut.Controls.Add(this.textBox5);
            this.Laskut.Controls.Add(this.textBox4);
            this.Laskut.Controls.Add(this.label6);
            this.Laskut.Controls.Add(this.label5);
            this.Laskut.Controls.Add(this.label4);
            this.Laskut.Controls.Add(this.label3);
            this.Laskut.Controls.Add(this.lblLasku);
            this.Laskut.Location = new System.Drawing.Point(4, 22);
            this.Laskut.Name = "Laskut";
            this.Laskut.Size = new System.Drawing.Size(777, 739);
            this.Laskut.TabIndex = 3;
            this.Laskut.Text = "Laskut";
            this.Laskut.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(509, 566);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 77);
            this.button3.TabIndex = 16;
            this.button3.Text = "Poista lasku";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(35, 566);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 77);
            this.button4.TabIndex = 15;
            this.button4.Text = "Hae lasku";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(272, 566);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 77);
            this.button5.TabIndex = 14;
            this.button5.Text = "Luo lasku";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.textBox8.Location = new System.Drawing.Point(330, 170);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 32);
            this.textBox8.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.textBox7.Location = new System.Drawing.Point(330, 218);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(219, 32);
            this.textBox7.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.textBox5.Location = new System.Drawing.Point(330, 270);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 32);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.textBox4.Location = new System.Drawing.Point(330, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 32);
            this.textBox4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Asiakasnumero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Summa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mökkinumero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Viitenumero";
            // 
            // lblLasku
            // 
            this.lblLasku.AutoSize = true;
            this.lblLasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblLasku.Location = new System.Drawing.Point(292, 50);
            this.lblLasku.Name = "lblLasku";
            this.lblLasku.Size = new System.Drawing.Size(99, 26);
            this.lblLasku.TabIndex = 0;
            this.lblLasku.Text = "Laskutus";
            // 
            // Muokkaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.Mökit);
            this.Name = "Muokkaa";
            this.Text = "Muokkaa";
            this.Mökit.ResumeLayout(false);
            this.Mokit.ResumeLayout(false);
            this.Mokit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Palvelut.ResumeLayout(false);
            this.Palvelut.PerformLayout();
            this.Asiakkaat.ResumeLayout(false);
            this.Asiakkaat.PerformLayout();
            this.Laskut.ResumeLayout(false);
            this.Laskut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Mökit;
        private System.Windows.Forms.TabPage Mokit;
        private System.Windows.Forms.Button btnLisaaMokki;
        private System.Windows.Forms.Label lblMajoituspaikat;
        private System.Windows.Forms.Label lblToimialue;
        private System.Windows.Forms.Label lblOsoite;
        private System.Windows.Forms.Label lblMokinNimi;
        private System.Windows.Forms.TabPage Palvelut;
        private System.Windows.Forms.TabPage Asiakkaat;
        private System.Windows.Forms.TabPage Laskut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxOminaisuudet;
        private System.Windows.Forms.TextBox tbMokinNimi;
        private System.Windows.Forms.TextBox tbMokinOsoite;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tbMokinHinta;
        private System.Windows.Forms.Label lblMokinHinta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxPalvelut;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPalvelunKuvaus;
        private System.Windows.Forms.Label lblPalvelunHinta;
        private System.Windows.Forms.Label lblPalvelunNimi;
        private System.Windows.Forms.Button btnPoistaPalvelu;
        private System.Windows.Forms.Button btnLisaaPalvelu;
        private System.Windows.Forms.TextBox tbAsiakasnumero;
        private System.Windows.Forms.Label lblAsiakasnumero;
        private System.Windows.Forms.Button btnPoistaAsiakas;
        private System.Windows.Forms.Button btnLisaaAsiakas;
        private System.Windows.Forms.TextBox tbSposti;
        private System.Windows.Forms.Label lblSposti;
        private System.Windows.Forms.TextBox tbAsiakkaanPuhNum;
        private System.Windows.Forms.TextBox tbAsiakkaanOsoite;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblPuhNum;
        private System.Windows.Forms.Label lblAsiakkaanOsoite;
        private System.Windows.Forms.Label lblAsiakkaanNimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLasku;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}