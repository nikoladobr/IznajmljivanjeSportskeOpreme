using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class ZaposleniTerminDezurstva
    {
        public int IdZaposleni { get; set; }
        public int IdTerminDezurstva { get; set; }
        public DateTime DatumDezurstva { get; set; }

        public override string ToString()
        {
            return DatumDezurstva.ToString("dd.MM.yyyy");
        }
    }
}
