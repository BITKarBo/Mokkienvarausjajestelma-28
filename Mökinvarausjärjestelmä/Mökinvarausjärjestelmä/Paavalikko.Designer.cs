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
            this.Toimialueboksi = new System.Windows.Forms.ComboBox();
            this.btnUusiVaraus = new System.Windows.Forms.Button();
            this.btnKalenteri = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Toimialueboksi
            // 
            this.Toimialueboksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Toimialueboksi.FormattingEnabled = true;
            this.Toimialueboksi.Items.AddRange(new object[] {
            "Ruka",
            "Ylläs",
            "Tahko"});
            this.Toimialueboksi.Location = new System.Drawing.Point(266, 108);
            this.Toimialueboksi.Name = "Toimialueboksi";
            this.Toimialueboksi.Size = new System.Drawing.Size(193, 28);
            this.Toimialueboksi.TabIndex = 0;
            this.Toimialueboksi.Text = "Toimialue";
            // 
            // btnUusiVaraus
            // 
            this.btnUusiVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnUusiVaraus.Location = new System.Drawing.Point(265, 180);
            this.btnUusiVaraus.Name = "btnUusiVaraus";
            this.btnUusiVaraus.Size = new System.Drawing.Size(193, 42);
            this.btnUusiVaraus.TabIndex = 2;
            this.btnUusiVaraus.Text = "Uusi varaus";
            this.btnUusiVaraus.UseVisualStyleBackColor = true;
            this.btnUusiVaraus.Click += new System.EventHandler(this.btnUusiVaraus_Click);
            // 
            // btnKalenteri
            // 
            this.btnKalenteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnKalenteri.Location = new System.Drawing.Point(265, 242);
            this.btnKalenteri.Name = "btnKalenteri";
            this.btnKalenteri.Size = new System.Drawing.Size(194, 48);
            this.btnKalenteri.TabIndex = 3;
            this.btnKalenteri.Text = "Varaus kalenteri";
            this.btnKalenteri.UseVisualStyleBackColor = true;
            this.btnKalenteri.Click += new System.EventHandler(this.btnKalenteri_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMuokkaa.Location = new System.Drawing.Point(264, 322);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(194, 55);
            this.btnMuokkaa.TabIndex = 4;
            this.btnMuokkaa.Text = "Muokkaa / Lisää";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // Paavalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnKalenteri);
            this.Controls.Add(this.btnUusiVaraus);
            this.Controls.Add(this.Toimialueboksi);
            this.Name = "Paavalikko";
            this.Text = "Paavalikko";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Toimialueboksi;
        private System.Windows.Forms.Button btnUusiVaraus;
        private System.Windows.Forms.Button btnKalenteri;
        private System.Windows.Forms.Button btnMuokkaa;
    }
}