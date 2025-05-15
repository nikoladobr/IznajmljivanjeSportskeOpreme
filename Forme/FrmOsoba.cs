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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Forme
{
    public partial class FrmOsoba : Form
    {
        public FrmOsoba()
        {
            InitializeComponent();
            cbKategorija.DataSource = Kontroler.Instance.VratiListuSviKategorijaOsobe();
            dgvOsobe.DataSource = Kontroler.Instance.VratiListuSviOsobe();
            
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Email = txtEmail.Text,
                Kategorija = (KategorijaOsobe)cbKategorija.SelectedItem
            };

            try
            {
     
                List<Osoba> rezultat = Kontroler.Instance.PretraziOsobe(osoba);

     
                if (rezultat == null || rezultat.Count == 0)
                {
                    MessageBox.Show("Систем не може да нађе особе по задатим критеријумима.", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvOsobe.DataSource = null;
                    return;
                }

                dgvOsobe.DataSource = rezultat;
                MessageBox.Show("Систем је нашао особе по задатим критеријумима.", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Дошло је до грешке при претрази.\n" + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvOsobe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Молимо изаберите особу за брисање.");
                return;
            }

            Osoba o = (Osoba)dgvOsobe.SelectedRows[0].DataBoundItem;

            DialogResult dr = MessageBox.Show($"Да ли сте сигурни да желите да обришете особу: {o.Ime} {o.Prezime}?", "Потврда брисања", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                bool uspesno = Kontroler.Instance.ObrisiOsoba(o);
                if (uspesno)
                {
                    MessageBox.Show("Систем је обрисао особу.");
                }
                else
                {
                    MessageBox.Show("Систем не може да обрише особу.");
                }
            }
        }
    }
}
