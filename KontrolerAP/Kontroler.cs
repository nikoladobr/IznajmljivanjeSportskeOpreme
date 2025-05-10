using BrokerBP;
using Domen;

namespace KontrolerAP
{
    public class Kontroler
    {
        private static Kontroler instance;
        public static Kontroler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Kontroler();
                }
                return instance;
            }
        }
        Broker broker = new Broker();

        public List<TerminDezurstva> VratiListuSviTerminDezurstva()
        {
            try
            {
                broker.OpenConn();
                return broker.VratiListuSviTerminDezurstva();
            }
            finally
            {
                broker.CloseConn();
            }
        }

        public bool KreirajZaposleni(Zaposleni z)
        {
            try
            {
                broker.OpenConn();
                return broker.KreirajZaposleni(z);

            }
            finally
            {
                broker.CloseConn();
            }

        }
        public bool PostojiKorisnickoIme(string korisnickoIme)
        {
            try
            {
                broker.OpenConn();
                return broker.PostojiKorisnickoIme(korisnickoIme);
            }
            finally
            {
                broker.CloseConn();
            }
        }

        public Zaposleni PrijaviZaposleni(string korisnickoIme, string sifra)
        {
            try
            {
                broker.OpenConn();
                return broker.PrijaviZaposleni(korisnickoIme, sifra);
            }
            finally
            {
                broker.CloseConn();
            }
        }

        public List<KategorijaOsobe> VratiListuSviKategorijaOsobe()
        {
            try
            {
                broker.OpenConn();
                return broker.VratiListuSviKategorijaOsobe();
            }
            finally
            {
                broker.CloseConn();
            }
        }

        public void KreirajOsobu(Osoba osoba)
        {
            try
            {
                broker.OpenConn();
                broker.KreirajOsobu(osoba);
            }
            finally
            {
                broker.CloseConn();
            }
        }
    }
}