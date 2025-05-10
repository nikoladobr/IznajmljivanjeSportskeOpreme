using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Oprema
    {
        public int IdOprema { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
