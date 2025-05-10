using Domen;
using KontrolerAP;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistracija frm = new();
            frm.ShowDialog();
            this.Show();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || string.IsNullOrWhiteSpace(txtSifra.Text))
            {
                MessageBox.Show("Morate uneti korisničko ime i šifru!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string korisnickoIme = txtKorisnickoIme.Text;
            string sifra = txtSifra.Text;

            Zaposleni prijavljeni = Kontroler.Instance.PrijaviZaposleni(korisnickoIme, sifra);

            if (prijavljeni != null)
            {
                MessageBox.Show("Корисничко име и шифра су исправни.", "Обавештење", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                FrmGlavna frm = new FrmGlavna();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Корисничко име и шифра нису исправни", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}