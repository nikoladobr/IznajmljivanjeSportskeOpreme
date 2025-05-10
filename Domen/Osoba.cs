using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Osoba
    {
        public int IdOsoba { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public int IdKategorijaOsobe { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
