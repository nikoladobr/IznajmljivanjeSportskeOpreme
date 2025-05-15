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

        private void kreirajOsobuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKreirajOsobu frmKreiraj = new();
            frmKreiraj.ShowDialog();
            this.Show();
        }

        private void upravljanjeOsobamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOsoba frmOsoba = new();
            frmOsoba.ShowDialog();
            this.Show();
        }
    }
}
