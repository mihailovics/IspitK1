using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    public class Apartman : Smestaj
    {
        private bool ImaKuhinju;
        public Apartman(double cenaPoNoci, bool imaKuhinju) : base(cenaPoNoci)
        {
            this.ImaKuhinju = imaKuhinju;
        }

        public bool ImaKuhinjuGetSet { get => ImaKuhinju; set => ImaKuhinju = value; }
        
    }
}
