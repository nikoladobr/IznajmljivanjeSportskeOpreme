using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class StavkaIznajmljivanja
    {
        public int IdIznajmljivanje { get; set; }
        public int Rb { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public double Cena { get; set; }
        public DateTime VremeDo { get; set; }
        public int Trajanje { get; set; }
        public double Iznos { get; set; }
        public int IdOprema { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
