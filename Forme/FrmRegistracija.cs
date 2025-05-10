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
    public partial class FrmRegistracija : Form
    {
        public FrmRegistracija()
        {
            InitializeComponent();
            
            
        }

        private void FrmRegistracija_Load(object sender, EventArgs e)
        {
            List<TerminDezurstva> lista = Kontroler.Instance.VratiListuSviTerminDezurstva();

            clbTerminDezurstva.Items.Clear();
            foreach(TerminDezurstva termin in lista)
            {
                clbTerminDezurstva.Items.Add(termin);
            }


        }

        private void btnRegistruj_Click(object sender, EventArgs e)
        {
            string sifra = txtSifra.Text;

            if (sifra.Length < 8 || !sifra.Any(c => char.IsUpper(c)))
            {
                MessageBox.Show("Šifra mora imati najmanje 8 karaktera i bar jedno veliko slovo.");
                return;
            }

            if (txtSifra.Text != txtPotvrdiSifru.Text)
            {
                MessageBox.Show("Šifre se ne poklapaju.");
                return;
            }

            Zaposleni novi = new Zaposleni();
           novi.Sifra = txtSifra.Text;
           novi.Ime = txtIme.Text;
           novi.Prezime = txtPrezime.Text;
           novi.KorisnickoIme = txtKorisnickoIme.Text;

            if (Kontroler.Instance.PostojiKorisnickoIme(novi.KorisnickoIme))
            {
                MessageBox.Show("Zaposleni sa tim korisničkim imenom već postoji.");
                return;
            }

            bool uspesno = Kontroler.Instance.KreirajZaposleni(novi);

            if (uspesno)
            {
                MessageBox.Show("Uspešno ste registrovali zaposlenog. Možete da se prijavite.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Greška pri registraciji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
