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
    public partial class FrmZaposleni : Form
    {
        public FrmZaposleni()
        {
            InitializeComponent();
            dgvZaposleni.DataSource = Kontroler.Instance.VratiListuSviZaposleni();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            Zaposleni zaposleni = new Zaposleni
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                KorisnickoIme = txtKorisnickoIme.Text
            };

            // Преузимање изабраних смена из clbTerminDezurstva
            List<TerminDezurstva> izabraneSmene = new();
            foreach (var item in clbTerminDezurstva.CheckedItems)
            {
                izabraneSmene.Add((TerminDezurstva)item);
            }

            try
            {
                List<Zaposleni> rezultat = Kontroler.Instance.PretraziZaposlene(zaposleni, izabraneSmene);

                if (rezultat == null || rezultat.Count == 0)
                {
                    MessageBox.Show("Систем не може да нађе запослене по задатим критеријумима.", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvZaposleni.DataSource = null;
                    return;
                }

                dgvZaposleni.DataSource = rezultat;
                MessageBox.Show("Систем је нашао запослене по задатим критеријумима.", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Дошло је до грешке при претрази.\n" + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void FrmZaposleni_Load(object sender, EventArgs e)
        {
            List<TerminDezurstva> lista = Kontroler.Instance.VratiListuSviTerminDezurstva();

            clbTerminDezurstva.Items.Clear();
            foreach (TerminDezurstva termin in lista)
            {
                clbTerminDezurstva.Items.Add(termin);
            }
        }
    }
}
