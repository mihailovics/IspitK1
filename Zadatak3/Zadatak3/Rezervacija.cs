using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    public class Rezervacija
    {
        private Korisnik Korisnik;
        private Smestaj Smestaj;
        private int TrajanjeNoci;

        public Rezervacija(Korisnik korisnik, Smestaj smestaj, int trajanjeNoci)
        {
            this.Korisnik = korisnik;
            this.Smestaj = smestaj;
            this.TrajanjeNoci = trajanjeNoci;
        }

        public Korisnik KorisnikGetSet { get => Korisnik; set => Korisnik = value; }

        public Smestaj SmestajGetSet { get => Smestaj; set => Smestaj = value; }

        public int TrajanjeNociGetSet { get => TrajanjeNoci; set=> TrajanjeNoci = value; }

        public void IzracunajUkupnuCenu()
        {
            Console.WriteLine("Cena za " + TrajanjeNoci + " noci iznosi: " + Smestaj.CenaPoNociGetSet*TrajanjeNoci + " dinara");
        }

    }
}
