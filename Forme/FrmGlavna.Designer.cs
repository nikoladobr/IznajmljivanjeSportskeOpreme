namespace Forme
{
    partial class FrmGlavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.primalacUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajOsobuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeOsobamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primalacUslugeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // primalacUslugeToolStripMenuItem
            // 
            this.primalacUslugeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobaToolStripMenuItem});
            this.primalacUslugeToolStripMenuItem.Name = "primalacUslugeToolStripMenuItem";
            this.primalacUslugeToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.primalacUslugeToolStripMenuItem.Text = "Primalac usluge";
            // 
            // osobaToolStripMenuItem
            // 
            this.osobaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajOsobuToolStripMenuItem,
            this.upravljanjeOsobamaToolStripMenuItem});
            this.osobaToolStripMenuItem.Name = "osobaToolStripMenuItem";
            this.osobaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osobaToolStripMenuItem.Text = "Osoba";
            // 
            // kreirajOsobuToolStripMenuItem
            // 
            this.kreirajOsobuToolStripMenuItem.Name = "kreirajOsobuToolStripMenuItem";
            this.kreirajOsobuToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kreirajOsobuToolStripMenuItem.Text = "Kreiraj osobu";
            this.kreirajOsobuToolStripMenuItem.Click += new System.EventHandler(this.kreirajOsobuToolStripMenuItem_Click);
            // 
            // upravljanjeOsobamaToolStripMenuItem
            // 
            this.upravljanjeOsobamaToolStripMenuItem.Name = "upravljanjeOsobamaToolStripMenuItem";
            this.upravljanjeOsobamaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.upravljanjeOsobamaToolStripMenuItem.Text = "Upravljanje osobama";
            this.upravljanjeOsobamaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjeOsobamaToolStripMenuItem_Click);
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGlavna";
            this.Text = "FrmGlavna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem primalacUslugeToolStripMenuItem;
        private ToolStripMenuItem osobaToolStripMenuItem;
        private ToolStripMenuItem kreirajOsobuToolStripMenuItem;
        private ToolStripMenuItem upravljanjeOsobamaToolStripMenuItem;
    }
}