using MyFirstCat;
using static System.Runtime.InteropServices.JavaScript.JSType;

bool besuch = true;
Tierheim myTier = new Tierheim();

void tierConsole()
{
    while (besuch)
    {
        Console.WriteLine("Willst du ein Tier hinzufügen (ja oder nein)");
        string addCatRead = Console.ReadLine();
        if (addCatRead == "ja" || addCatRead == "nein")
        {
            if (addCatRead == "ja")
            {
                Console.WriteLine("Wann ist das Tier geboren worden? ");
                string catBirthDate = Console.ReadLine();
                if (DateTime.TryParse(catBirthDate, out DateTime dtBirth))
                {
                    Console.WriteLine("Welche Farbe hat das Tier?");
                    string catColor = Console.ReadLine();
                    Console.WriteLine("Wie heißt das Tier?");
                    string catName = Console.ReadLine();
                    myTier.AddAnimal(new Katze(dtBirth, catColor, catName));
                    Console.WriteLine("Hier ist die Liste mit allen Katzen:");
                    myTier.ShowAnimals();
                    Console.WriteLine("Willst du noch eine weitere Katze hinzufügen? (ja oder nein)");
                    string addCatAgain = Console.ReadLine();
                    if (addCatAgain == "ja")
                    {
                        tierConsole();
                    }
                    else if (addCatAgain == "nein")
                    {
                        besuch = false;
                    }
                }
                else
                {
                    Console.WriteLine("Dies ist das falsche Format");
                }
            }
            else if (addCatRead == "nein")
            {
                besuch = false;
            }
        }
        else
        {
            Console.WriteLine("Das ist keine gültige Eingabe!");
        }
    }
}
tierConsole();