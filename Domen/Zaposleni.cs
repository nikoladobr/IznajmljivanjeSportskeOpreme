namespace Domen
{
    public class Zaposleni
    {
        public int IdZaposleni { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }

        public override string ToString() => $"{Ime} {Prezime}";
    }
}