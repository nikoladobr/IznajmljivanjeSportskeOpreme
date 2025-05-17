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
            this.osobaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajOsobuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeOsobamaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajZaposlenogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeZaposlenimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobaToolStripMenuItem1,
            this.zaposleniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // osobaToolStripMenuItem1
            // 
            this.osobaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajOsobuToolStripMenuItem1,
            this.upravljanjeOsobamaToolStripMenuItem1});
            this.osobaToolStripMenuItem1.Name = "osobaToolStripMenuItem1";
            this.osobaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.osobaToolStripMenuItem1.Text = "Osoba";
            // 
            // kreirajOsobuToolStripMenuItem1
            // 
            this.kreirajOsobuToolStripMenuItem1.Name = "kreirajOsobuToolStripMenuItem1";
            this.kreirajOsobuToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.kreirajOsobuToolStripMenuItem1.Text = "Kreiraj osobu";
            this.kreirajOsobuToolStripMenuItem1.Click += new System.EventHandler(this.kreirajOsobuToolStripMenuItem1_Click);
            // 
            // upravljanjeOsobamaToolStripMenuItem1
            // 
            this.upravljanjeOsobamaToolStripMenuItem1.Name = "upravljanjeOsobamaToolStripMenuItem1";
            this.upravljanjeOsobamaToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.upravljanjeOsobamaToolStripMenuItem1.Text = "Upravljanje osobama";
            this.upravljanjeOsobamaToolStripMenuItem1.Click += new System.EventHandler(this.upravljanjeOsobamaToolStripMenuItem1_Click);
            // 
            // zaposleniToolStripMenuItem
            // 
            this.zaposleniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajZaposlenogToolStripMenuItem,
            this.upravljanjeZaposlenimaToolStripMenuItem});
            this.zaposleniToolStripMenuItem.Name = "zaposleniToolStripMenuItem";
            this.zaposleniToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.zaposleniToolStripMenuItem.Text = "Zaposleni";
            // 
            // kreirajZaposlenogToolStripMenuItem
            // 
            this.kreirajZaposlenogToolStripMenuItem.Name = "kreirajZaposlenogToolStripMenuItem";
            this.kreirajZaposlenogToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.kreirajZaposlenogToolStripMenuItem.Text = "Kreiraj zaposlenog";
            this.kreirajZaposlenogToolStripMenuItem.Click += new System.EventHandler(this.kreirajZaposlenogToolStripMenuItem_Click);
            // 
            // upravljanjeZaposlenimaToolStripMenuItem
            // 
            this.upravljanjeZaposlenimaToolStripMenuItem.Name = "upravljanjeZaposlenimaToolStripMenuItem";
            this.upravljanjeZaposlenimaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.upravljanjeZaposlenimaToolStripMenuItem.Text = "Upravljanje zaposlenima";
            this.upravljanjeZaposlenimaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjeZaposlenimaToolStripMenuItem_Click);
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
        private ToolStripMenuItem zaposleniToolStripMenuItem;
        private ToolStripMenuItem osobaToolStripMenuItem1;
        private ToolStripMenuItem kreirajOsobuToolStripMenuItem1;
        private ToolStripMenuItem upravljanjeOsobamaToolStripMenuItem1;
        private ToolStripMenuItem kreirajZaposlenogToolStripMenuItem;
        private ToolStripMenuItem upravljanjeZaposlenimaToolStripMenuItem;
    }
}