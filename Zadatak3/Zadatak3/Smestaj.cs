using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    public class Smestaj
    {
        private double CenaPoNoci;

        public Smestaj(double cenaPoNoci)
        {
            this.CenaPoNoci = cenaPoNoci;
        }

        public double CenaPoNociGetSet { get {  return this.CenaPoNoci; } set {  this.CenaPoNoci = value;} }

        public override string ToString()
        {
            return "Cena za noc u ovom smestaju iznosi: " + CenaPoNoci + " dinara.";
        }
    }
}
