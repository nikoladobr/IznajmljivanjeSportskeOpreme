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
    public partial class FrmKreirajZaposlenog : Form
    {
        public FrmKreirajZaposlenog()
        {
            InitializeComponent();                   
        }

        private void FrmKreirajZaposlenog_Load(object sender, EventArgs e)
        {
            List<TerminDezurstva> lista = Kontroler.Instance.VratiListuSviTerminDezurstva();

            clbTerminDezurstva.Items.Clear();
            foreach(TerminDezurstva termin in lista)
            {
                clbTerminDezurstva.Items.Add(termin);
            }
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            // Валидација у складу са документацијом
            if (string.IsNullOrWhiteSpace(txtIme.Text) ||
                string.IsNullOrWhiteSpace(txtPrezime.Text) ||
                string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) ||
                string.IsNullOrWhiteSpace(txtSifra.Text))
            {
                MessageBox.Show("Сва поља су обавезна.");
                return;
            }

            if (txtSifra.Text.Length < 8 || !txtSifra.Text.Any(char.IsUpper))
            {
                MessageBox.Show("Шифра мора садржати најмање 8 карактера и бар једно велико слово.");
                return;
            }

            if (clbTerminDezurstva.CheckedItems.Count == 0)
            {
                MessageBox.Show("Изаберите бар један термин дежурства.");
                return;
            }

            // Креирање запосленог
            Zaposleni zaposleni = new Zaposleni
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                KorisnickoIme = txtKorisnickoIme.Text,
                Sifra = txtSifra.Text
            };

            // Позив контролера
            bool uspesno = Kontroler.Instance.KreirajZaposleni(zaposleni);

            if (!uspesno)
            {
                MessageBox.Show("Систем не може да креира запосленог.");
                return;
            }

            // Након успешног уноса, добијамо ID тог запосленог преко корисничког имена
            int idZaposleni = Kontroler.Instance.VratiIdZaposlenogPoKorisnickomImenu(zaposleni.KorisnickoIme);

            // Унос термина дежурства
            foreach (var item in clbTerminDezurstva.CheckedItems)
            {
                TerminDezurstva t = (TerminDezurstva)item;

                ZaposleniTerminDezurstva ztd = new ZaposleniTerminDezurstva
                {
                    IdZaposleni = idZaposleni,
                    IdTerminDezurstva = t.IdTerminDezurstva,
                    DatumDezurstva = DateTime.Now
                };

                Kontroler.Instance.UbaciZaposleniTermin(ztd);
            }

            MessageBox.Show("Систем је запамтио запосленог.");
          
        }
    }
}
