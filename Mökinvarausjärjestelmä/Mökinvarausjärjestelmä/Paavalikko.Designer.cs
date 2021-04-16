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
            this.Toimialuetxtbox = new System.Windows.Forms.TextBox();
            this.uusivarausbtn = new System.Windows.Forms.Button();
            this.varauksetkalenteriinbtn = new System.Windows.Forms.Button();
            this.muokkaabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Toimialueboksi
            // 
            this.Toimialueboksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toimialueboksi.FormattingEnabled = true;
            this.Toimialueboksi.Items.AddRange(new object[] {
            "Ruka",
            "Ylläs",
            "Tahko"});
            this.Toimialueboksi.Location = new System.Drawing.Point(266, 108);
            this.Toimialueboksi.Name = "Toimialueboksi";
            this.Toimialueboksi.Size = new System.Drawing.Size(193, 33);
            this.Toimialueboksi.TabIndex = 0;
            // 
            // Toimialuetxtbox
            // 
            this.Toimialuetxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toimialuetxtbox.Location = new System.Drawing.Point(265, 71);
            this.Toimialuetxtbox.Name = "Toimialuetxtbox";
            this.Toimialuetxtbox.Size = new System.Drawing.Size(105, 31);
            this.Toimialuetxtbox.TabIndex = 1;
            this.Toimialuetxtbox.Text = "Toimialue";
            // 
            // uusivarausbtn
            // 
            this.uusivarausbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uusivarausbtn.Location = new System.Drawing.Point(266, 176);
            this.uusivarausbtn.Name = "uusivarausbtn";
            this.uusivarausbtn.Size = new System.Drawing.Size(193, 42);
            this.uusivarausbtn.TabIndex = 2;
            this.uusivarausbtn.Text = "Uusi varaus";
            this.uusivarausbtn.UseVisualStyleBackColor = true;
            // 
            // varauksetkalenteriinbtn
            // 
            this.varauksetkalenteriinbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varauksetkalenteriinbtn.Location = new System.Drawing.Point(265, 242);
            this.varauksetkalenteriinbtn.Name = "varauksetkalenteriinbtn";
            this.varauksetkalenteriinbtn.Size = new System.Drawing.Size(194, 48);
            this.varauksetkalenteriinbtn.TabIndex = 3;
            this.varauksetkalenteriinbtn.Text = "Varaus kalenteri";
            this.varauksetkalenteriinbtn.UseVisualStyleBackColor = true;
            // 
            // muokkaabtn
            // 
            this.muokkaabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaabtn.Location = new System.Drawing.Point(265, 318);
            this.muokkaabtn.Name = "muokkaabtn";
            this.muokkaabtn.Size = new System.Drawing.Size(194, 55);
            this.muokkaabtn.TabIndex = 4;
            this.muokkaabtn.Text = "Muokkaa / Lisää";
            this.muokkaabtn.UseVisualStyleBackColor = true;
            // 
            // Paavalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.muokkaabtn);
            this.Controls.Add(this.varauksetkalenteriinbtn);
            this.Controls.Add(this.uusivarausbtn);
            this.Controls.Add(this.Toimialuetxtbox);
            this.Controls.Add(this.Toimialueboksi);
            this.Name = "Paavalikko";
            this.Text = "Paavalikko";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Toimialueboksi;
        private System.Windows.Forms.TextBox Toimialuetxtbox;
        private System.Windows.Forms.Button uusivarausbtn;
        private System.Windows.Forms.Button varauksetkalenteriinbtn;
        private System.Windows.Forms.Button muokkaabtn;
    }
}