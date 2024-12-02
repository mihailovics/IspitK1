using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    public class Korisnik
    {
        private string Ime, Prezime, Email;
        
        public Korisnik(string ime, string prezime, string email)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
        }

        public string ImeGetSet { get => Ime; set => Ime = value; }
        public string PrezimeGetSet { get => Prezime;  set => Prezime = value; }
        public string EmailGetSet { get => Email; set => Email = value; } 

    }
}
