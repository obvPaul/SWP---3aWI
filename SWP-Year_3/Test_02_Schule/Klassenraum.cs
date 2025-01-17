using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_02_Schule
{
    public class Klassenraum 
    {
        public double Laenge {  get; set; }
        public double Breite { get; set; }
        public bool Cynap { get; set; }
        public int AnzahlPlaetze { get; set; }
        public double Größe()
        {
            return Laenge * Breite;
        }

    }
}
