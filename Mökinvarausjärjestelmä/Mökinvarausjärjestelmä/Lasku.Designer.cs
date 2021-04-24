namespace Mökinvarausjärjestelmä
{
    partial class Lasku
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLaheta = new System.Windows.Forms.Button();
            this.cbSahkoposti = new System.Windows.Forms.CheckBox();
            this.cbPaperiLasku = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.btnLaheta);
            this.panel3.Controls.Add(this.cbSahkoposti);
            this.panel3.Controls.Add(this.cbPaperiLasku);
            this.panel3.Location = new System.Drawing.Point(12, 565);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 184);
            this.panel3.TabIndex = 1;
            // 
            // btnLaheta
            // 
            this.btnLaheta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaheta.Location = new System.Drawing.Point(603, 61);
            this.btnLaheta.Name = "btnLaheta";
            this.btnLaheta.Size = new System.Drawing.Size(141, 73);
            this.btnLaheta.TabIndex = 2;
            this.btnLaheta.Text = "Lähetä";
            this.btnLaheta.UseVisualStyleBackColor = true;
            // 
            // cbSahkoposti
            // 
            this.cbSahkoposti.AutoSize = true;
            this.cbSahkoposti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSahkoposti.Location = new System.Drawing.Point(18, 110);
            this.cbSahkoposti.Name = "cbSahkoposti";
            this.cbSahkoposti.Size = new System.Drawing.Size(155, 24);
            this.cbSahkoposti.TabIndex = 1;
            this.cbSahkoposti.Text = "Sähköposti Lasku";
            this.cbSahkoposti.UseVisualStyleBackColor = true;
            // 
            // cbPaperiLasku
            // 
            this.cbPaperiLasku.AutoSize = true;
            this.cbPaperiLasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaperiLasku.Location = new System.Drawing.Point(18, 61);
            this.cbPaperiLasku.Name = "cbPaperiLasku";
            this.cbPaperiLasku.Size = new System.Drawing.Size(120, 24);
            this.cbPaperiLasku.TabIndex = 0;
            this.cbPaperiLasku.Text = "Paperi Lasku";
            this.cbPaperiLasku.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 547);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Sähköposti";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Osoite";
            // 
            // Lasku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "Lasku";
            this.Text = "Lasku";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLaheta;
        private System.Windows.Forms.CheckBox cbSahkoposti;
        private System.Windows.Forms.CheckBox cbPaperiLasku;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}