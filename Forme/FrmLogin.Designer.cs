namespace Forme
{
    partial class FrmLogin
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
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(79, 138);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(88, 15);
            this.lblKorisnickoIme.TabIndex = 0;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblSifra
            // 
            this.lblSifra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(104, 191);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(33, 15);
            this.lblSifra.TabIndex = 1;
            this.lblSifra.Text = "Šifra:";
            // 
            // txtSifra
            // 
            this.txtSifra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSifra.Location = new System.Drawing.Point(173, 188);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(136, 23);
            this.txtSifra.TabIndex = 3;
            this.txtSifra.UseSystemPasswordChar = true;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(174, 136);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(136, 23);
            this.txtKorisnickoIme.TabIndex = 4;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrijava.Location = new System.Drawing.Point(189, 237);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(98, 23);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Name = "FrmLogin";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKorisnickoIme;
        private Label lblSifra;
        private TextBox txtSifra;
        private TextBox txtKorisnickoIme;
        private Button btnPrijava;
    }
}