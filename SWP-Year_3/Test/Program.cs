//Dies ist die Test-Datei und dies ist eine Nachricht für einen Test-Commit

using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
int IntAbfrage;
int Eingabe2;
int ddieren;
int Multiplikation;
int Division;
int Fakultaet = 1;

Console.WriteLine("Geben Sie etwas ein");
string Eingabe = Console.ReadLine();

if (int.TryParse(Eingabe, out IntAbfrage))
{
    Console.WriteLine("Sie haben eine ganze Zahl eingegeben, welche mathematische Operation möchten Sie darauf ausführen?\n1) Addition\n2) Multiplikation\n3) Division\n4) Fakultät\n5) Wurzelziehen");
    string MatheEingabe = Console.ReadLine();
    int MatheRechnung;

    if (int.TryParse(MatheEingabe, out MatheRechnung) && MatheRechnung == 1)
    {
        Console.WriteLine("Sie haben eine 1 eingegeben und wollen somit addieren. Geben Sie die zweite Zahl ein, welche Sie addieren wollen.");
        int.TryParse(Console.ReadLine(), out Eingabe2);
        ddieren = IntAbfrage + Eingabe2;
        Console.WriteLine("Ihr Ergebniss lautet " + ddieren);
    }
    else if (int.TryParse(MatheEingabe, out MatheRechnung) && MatheRechnung == 2)
    {
        Console.WriteLine("Sie haben eine 2 eingegeben und wollen somit multiplizieren. Geben Sie die zweite Zahl ein, welche Sie multiplizieren wollen.");
        int.TryParse(Console.ReadLine(), out Eingabe2);
        Multiplikation = IntAbfrage * Eingabe2;
        Console.WriteLine("Ihr Ergebniss lautet " + Multiplikation);
    }
    else if (int.TryParse(MatheEingabe, out MatheRechnung) && MatheRechnung == 3)
    {
        Console.WriteLine("Sie haben eine 2 eingegeben und wollen somit dividieren. Geben Sie die zweite Zahl ein, welche Sie dividieren wollen.");
        int.TryParse(Console.ReadLine(), out Eingabe2);
        Division = IntAbfrage / Eingabe2;
        Console.WriteLine("Ihr Ergebniss lautet " + Division);
    }
    else if (int.TryParse(MatheEingabe, out MatheRechnung) && MatheRechnung == 4)
    {
        for (int i = 1; i <= IntAbfrage; i++)
        {
            Fakultaet *= i;
        }
        Console.WriteLine("Ihr Ergebniss lautet " + Fakultaet);
    }
    else if (int.TryParse(MatheEingabe, out MatheRechnung) && MatheRechnung == 5)
    {
        Console.WriteLine("Ihr Ergebniss lautet " + Math.Sqrt(IntAbfrage));
    }
    else
    {
        Console.WriteLine("Sie haben keine von den oben angefragten Zahlen eingegeben. Versuchen Sie es erneut");
    }
}
else if (Eingabe.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
{
    Console.WriteLine("Sie haben eine Zeichenkette eingeben. Was wollen Sie damit machen?\n1) Alle Selbstlaute entfernen\n2) Die Zeichenkette umdrehen\n3) Die Anzahl an Zeichen ausgeben");
    string TextEingabe = Console.ReadLine();

    if (TextEingabe == "1")
    {
        string ergebnis = Regex.Replace(Eingabe, "[aeiouAEIOU]", "");
        Console.WriteLine("Ihr Ergebnis lautet " + ergebnis );
    }
    else if (TextEingabe == "2")
    {
        string ergebnis = new string(Eingabe.Reverse().ToArray());
        Console.WriteLine("Ihr Ergebnis lautet " + ergebnis);
    }
    else if (TextEingabe == "3")
    {
        int ergebnis = Eingabe.Length;
        Console.WriteLine("Ihr Ergebnis lautet " + ergebnis);
    }
}
else
{
    Console.WriteLine("Mit Ihrer Eingabe kann dieser Code nichts machen. Versuchen Sie es bitte erneut.");
}

// 1) Kontrollstrukturen kontrollieren den FLuss des Codes. Beispiele: if, switch, case
// 2) Clean Code bedeutet, dass der Code lesbar und übersichtlich geschrieben wird. Prinzipien sind, einrückungen, CamelCasing und dass man nicht zu viele Abstände macht
// 3) Parse ist weniger Fehlertolerant als TryParse. Man muss auf ein Catch bei Parse achten
// 4) Erstellt den int myInt mit dem Wert 42