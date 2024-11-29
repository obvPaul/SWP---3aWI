using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstCat
{
    class Katze : Tier
    {
        private DateTime _BirthDate;
        public string setColor { get; set; }
        public int setAge { get { return (DateTime.Now.Year - _BirthDate.Year); } }
        public Katze(DateTime birthdate, string color = "Nicht Verfügbar", string name = "nicht Verfügbar") : base(name)
        {
            _BirthDate = birthdate;
            setColor = color;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Farbe: {setColor}, Alter: {setAge}";
        }
    }
}