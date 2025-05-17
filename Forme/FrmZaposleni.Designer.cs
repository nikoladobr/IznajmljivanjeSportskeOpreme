namespace Forme
{
    partial class FrmZaposleni
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblSmena = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvZaposleni = new System.Windows.Forms.DataGridView();
            this.clbTerminDezurstva = new System.Windows.Forms.CheckedListBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 9);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 15);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 46);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(52, 15);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblSmena
            // 
            this.lblSmena.AutoSize = true;
            this.lblSmena.Location = new System.Drawing.Point(12, 120);
            this.lblSmena.Name = "lblSmena";
            this.lblSmena.Size = new System.Drawing.Size(46, 15);
            this.lblSmena.TabIndex = 2;
            this.lblSmena.Text = "Smena:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(106, 43);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(125, 23);
            this.txtPrezime.TabIndex = 3;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(106, 6);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(125, 23);
            this.txtIme.TabIndex = 4;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(125, 188);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(74, 23);
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvZaposleni
            // 
            this.dgvZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposleni.Location = new System.Drawing.Point(264, 5);
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.RowTemplate.Height = 25;
            this.dgvZaposleni.Size = new System.Drawing.Size(437, 433);
            this.dgvZaposleni.TabIndex = 7;
            // 
            // clbTerminDezurstva
            // 
            this.clbTerminDezurstva.FormattingEnabled = true;
            this.clbTerminDezurstva.Location = new System.Drawing.Point(106, 109);
            this.clbTerminDezurstva.Name = "clbTerminDezurstva";
            this.clbTerminDezurstva.Size = new System.Drawing.Size(120, 58);
            this.clbTerminDezurstva.TabIndex = 8;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(12, 83);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(88, 15);
            this.lblKorisnickoIme.TabIndex = 9;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(106, 80);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(125, 23);
            this.txtKorisnickoIme.TabIndex = 10;
            // 
            // FrmZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.clbTerminDezurstva);
            this.Controls.Add(this.dgvZaposleni);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblSmena);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "FrmZaposleni";
            this.Text = "FrmZaposleni";
            this.Load += new System.EventHandler(this.FrmZaposleni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIme;
        private Label lblPrezime;
        private Label lblSmena;
        private TextBox txtPrezime;
        private TextBox txtIme;
        private Button btnPretrazi;
        private DataGridView dgvZaposleni;
        private CheckedListBox clbTerminDezurstva;
        private Label lblKorisnickoIme;
        private TextBox txtKorisnickoIme;
    }
}