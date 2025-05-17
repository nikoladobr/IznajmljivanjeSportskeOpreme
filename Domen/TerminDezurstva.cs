using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class TerminDezurstva
    {
        public int IdZaposleni { get; set; }
        public int IdTerminDezurstva { get; set; }
        public int Smena { get; set; }

        public override string ToString()
        {
            return $"{Smena}. Smena";
        }
    }
}
