using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Iznajmljivanje
    {
        public int IdIznajmljivanje { get; set; }
        public string Opis { get; set; }
        public double UkupanIznos { get; set; }
        public DateTime VremeOd { get; set; }
        public int IdZaposleni { get; set; }
        public int IdOsoba { get; set; }

        public override string ToString()
        {
            return Opis;
        }
    }
}
