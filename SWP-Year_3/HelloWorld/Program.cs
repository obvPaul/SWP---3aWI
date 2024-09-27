// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;


// Programmieraufgabe 1
bool isInput = true;

Console.WriteLine("Schreibe etwas rein!");

while (isInput)
{
    string input = Console.ReadLine();
        if (int.TryParse(input, out int output))
        {
            int input2 = int.Parse(input);
            Console.WriteLine("Deine Zahl wurde um 1 vergrößert: ");
            Console.Write(input2 + 1);
        }


    if (input == "Beenden")
    {
        isInput = false;
    }

}

