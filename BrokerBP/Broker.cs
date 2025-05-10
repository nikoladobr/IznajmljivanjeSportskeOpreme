using Domen;
using System.Data.SqlClient;

namespace BrokerBP
{
    public class Broker
    {
        SqlConnection conn;
        public Broker()
        {
            conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SportOpremaRentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public void OpenConn()
        {
            conn.Open();
        }
        public void CloseConn()
        {
            conn?.Close();
        }

        public List<TerminDezurstva> VratiListuSviTerminDezurstva()
        {
            List<TerminDezurstva> result = new();
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "select * from TerminDežurstva";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TerminDezurstva t = new();
                        t.IdTerminDezurstva = (int)reader["idTerminDezurstva"];
                        t.Smena = (int)reader["smena"];
                        result.Add(t);

                    }
                    return result;
                }
            }
        }

        public bool KreirajZaposleni(Zaposleni z)
        {
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Zaposleni (ime, prezime, korisnickoIme, sifra) VALUES (@ime, @prezime, @korisnickoIme, @sifra)";
                cmd.Parameters.AddWithValue("@ime", z.Ime);
                cmd.Parameters.AddWithValue("@prezime", z.Prezime);
                cmd.Parameters.AddWithValue("@korisnickoIme", z.KorisnickoIme);
                cmd.Parameters.AddWithValue("@sifra", z.Sifra);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool PostojiKorisnickoIme(string korisnickoIme)
        {
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Zaposleni WHERE korisnickoIme = @korisnickoIme";
                cmd.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public Zaposleni PrijaviZaposleni(string korisnickoIme, string sifra)
        {
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Zaposleni WHERE korisnickoIme = @korisnickoIme AND sifra = @sifra";
                cmd.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);
                cmd.Parameters.AddWithValue("@sifra", sifra);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Zaposleni
                        {
                            IdZaposleni = (int)reader["idZaposleni"],
                            Ime = reader["ime"].ToString(),
                            Prezime = reader["prezime"].ToString(),
                            KorisnickoIme = reader["korisnickoIme"].ToString(),
                            Sifra = reader["sifra"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public List<KategorijaOsobe> VratiListuSviKategorijaOsobe()
        {
            List<KategorijaOsobe> result = new();
            using(SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "select * from KategorijaOsobe";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KategorijaOsobe k = new();
                        k.IdKategorijaOsobe = (int)reader["idKategorijaOsobe"];
                        k.Naziv = reader["naziv"].ToString();
                        result.Add(k);
                    }
                    return result;
                }
            }           
        }

        public void KreirajOsobu(Osoba osoba)
        {
            using(SqlCommand cmd = conn.CreateCommand())
            {                
                    cmd.CommandText = "INSERT INTO Osoba (ime, prezime, email, idKategorijaOsobe) VALUES (@ime, @prezime, @email, @idKategorijaOsobe)";
                   
                    cmd.Parameters.AddWithValue("@ime", osoba.Ime);
                    cmd.Parameters.AddWithValue("@prezime", osoba.Prezime);
                    cmd.Parameters.AddWithValue("@email", osoba.Email);
                    cmd.Parameters.AddWithValue("@idKategorijaOsobe", osoba.Kategorija.IdKategorijaOsobe);

                    cmd.ExecuteNonQuery();                
            }
        }
    }
}