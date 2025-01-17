using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCat
{
    class Tierheim
    {
        public List<Katze> tiere = new List<Katze>();

        public void AddAnimal(Katze cat)
        {
            tiere.Add(cat);
            Console.WriteLine($"\nEs wurde die Katze {cat.Name} hinzugefügt!\n");
        }
        public void ShowAnimals()
        {
            int index = 1;
            foreach (var cat in tiere)
            {
                Console.WriteLine(cat.ToString());
            }
        }
    }