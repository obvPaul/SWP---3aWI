int SelbstlautCounter = 0;
var Selbstlaut = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

Console.WriteLine("Geben Sie einen satz ein");
string BenutzerEingabe = Console.ReadLine().ToLower();

for (int i = 0; i < BenutzerEingabe.Length; i++)
{
    if (Selbstlaut.Contains(BenutzerEingabe[i]))
    {
        SelbstlautCounter++;
    }
}
Console.WriteLine("In Ihrem Satz befinden sich " + SelbstlautCounter + " Selbstlaute");