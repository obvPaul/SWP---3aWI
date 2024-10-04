using System;
using System.Reflection.Metadata.Ecma335;


Console.WriteLine("Geben Sie eine Zahl ein");
string wertA = Console.ReadLine();

Console.WriteLine("Geben Sie eine 1 ein, wenn Sie quadrieren wollen, eine 2, wenn Sie eine Wurzel ziehen wollen und eine 3, wenn sie fakultieren möchten");
string eingabe = Console.ReadLine();
double check = Convert.ToDouble(eingabe);

if (check == 1 ||check == 2 ||check == 3) {

} 
else {
    Console.WriteLine("Die Zahl ist nicht Valid");
}

if (check == 1) {
    Console.WriteLine("Geben Sie die zweite Zahl ein");
    string wertB = Console.ReadLine();
    Console.WriteLine("Ihr Ergebnis lautet: " + Math.Pow(Convert.ToDouble(wertA), Convert.ToDouble(wertB)));
}
else if (check == 2) {
    Console.WriteLine("Ihr Ergebnis lautet: " + Math.Sqrt(Convert.ToDouble(wertA)));
}
else if (check ==3) {
    double fakultaet = 1;
        for (int i = 1; i <= Convert.ToDouble(wertA); i++)
        {
        fakultaet *= i;
        
        }
    Console.WriteLine("Ihr Ergebnis lautet: " + fakultaet);
}
