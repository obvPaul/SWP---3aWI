using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCat
{
    class Tier
    {
        public string Name { get; set; }
        public Tier(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}