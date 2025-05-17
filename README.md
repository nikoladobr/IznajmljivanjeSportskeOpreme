# Softverski sistem za iznajmljivanje sportske opreme (.NET, C#)

Desktop aplikacija za iznajmljivanje sportske opreme, razvijena kao univerzitetski projekat u okviru predmeta „Projektovanje softvera“ na Fakultetu organizacionih nauka.

##  Tehnologije i alati

- C# (.NET Framework)
- Windows Forms
- SQL Server (relacioni model baze)
- ADO.NET
- SSMS za upravljanje bazom
- Layered arhitektura (UI → Business → Data Access)

## Ključni entiteti

- **Zaposleni** – prijava, kreiranje, uređivanje, brisanje
- **Osoba** – korisnik koji iznajmljuje opremu
- **Iznajmljivanje** – dokument procesa (datum, oprema, ukupan iznos)
- **Oprema** – stavke koje se mogu iznajmiti
- **Termin dežurstva** – kada je zaposleni na dužnosti
- **Kategorija osobe** – tipovi korisnika

## Funkcionalnosti

- Prijava zaposlenih uz validaciju korisničkog imena i šifre
- CRUD operacije nad osobama, zaposlenima i opremom
- Upravljanje terminima dežurstava i kategorijama
- Iznajmljivanje opreme sa izračunavanjem ukupnog iznosa (cena × količina × trajanje)
- Detaljna pretraga i filtriranje po svim kriterijumima

## Baza podataka

Baza je dizajnirana na osnovu konceptualnog i relacionalnog modela. Uključuje strane ključeve, vrednosna ograničenja (npr. validacija e-maila, dužina šifre, opseg smene...) i veze n:1 i m:n između entiteta.

## Korisnički interfejs

UI razvijen pomoću Windows Forms:
- Navigacija kroz meni
- Obrasci za unos i prikaz podataka
- MessageBox poruke za greške i uspešne akcije

## Organizacija projekta

- `Forme/` – UI sloj
- `KontrolerAP/` – logika aplikacije (posrednik između UI i baze)
- `BrokerBP/` – rad sa bazom (ADO.NET)
- `Domen/` – modeli (Osoba, Oprema, Zaposleni...)

## Autor

Nikola Dobrosavljević
Faculty of Organizational Sciences, University of Belgrade (2024)
Mentor: prof. dr Siniša Vlajić
