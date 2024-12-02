using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    public class Hotel : Smestaj
    {
        private int BrojZvezdica;
        private bool DorucakUkljucen;
        public Hotel(double cenaPoNoci, int brojZvezdica, bool dorucakUkljucen) : base(cenaPoNoci)
        {
            this.BrojZvezdica = brojZvezdica;
            this.DorucakUkljucen = dorucakUkljucen;
        }

        public int BrojZvezdicaGetSet { get {  return this.BrojZvezdica;} set { this.BrojZvezdica = value; } }
        public bool DorucakUkljucenGetSet { get { return this.DorucakUkljucen;} set{ this.DorucakUkljucen = value; } }


    }
}
