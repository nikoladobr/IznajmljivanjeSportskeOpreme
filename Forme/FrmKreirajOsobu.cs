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
    public partial class FrmKreirajOsobu : Form
    {
        public FrmKreirajOsobu()
        {   
            InitializeComponent();
            cbKategorija.DataSource = Kontroler.Instance.VratiListuSviKategorijaOsobe();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Osoba osoba = null;

            try
            {
                
                osoba = new Osoba();

                if (osoba == null)
                { 
                    MessageBox.Show("Систем не може да креира особу.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                osoba.Ime = txtIme.Text.Trim();
                osoba.Prezime = txtPrezime.Text.Trim();
                osoba.Email = txtEmail.Text.Trim();
                osoba.Kategorija = (KategorijaOsobe)cbKategorija.SelectedItem;

                if (string.IsNullOrWhiteSpace(osoba.Ime) ||
                    string.IsNullOrWhiteSpace(osoba.Prezime) ||
                    string.IsNullOrWhiteSpace(osoba.Email) ||
                    osoba.Kategorija == null)
                {
                    MessageBox.Show("Сва поља су обавезна.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!osoba.Email.Contains("@"))
                {
                    MessageBox.Show("Email није валидан.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Систем је креирао особу.", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Kontroler.Instance.KreirajOsobu(osoba);

                MessageBox.Show("Систем је запамтио особу.", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            catch (Exception ex)
            {              
                MessageBox.Show("Систем не може да запамти особу.\n" + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
