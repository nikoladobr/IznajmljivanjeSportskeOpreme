using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void kreirajOsobuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKreirajOsobu frmKreiraj = new();
            frmKreiraj.ShowDialog();
            this.Show();
        }

        private void upravljanjeOsobamaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOsoba frmOsoba = new();
            frmOsoba.ShowDialog();
            this.Show();
        }

        private void upravljanjeZaposlenimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmZaposleni frmZaposleni = new();
            frmZaposleni.ShowDialog();
            this.Show();
        }

        private void kreirajZaposlenogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKreirajZaposlenog frmKreirajZaposleni = new();
            frmKreirajZaposleni.ShowDialog();
            this.Show();
        }
    }
}
