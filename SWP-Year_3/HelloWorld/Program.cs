using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;


bool isInput = true;

Console.WriteLine("Dieses Programm können Sie beenden, indem sie Beenden eingeben.");

while (isInput) {
    string input = Console.ReadLine();
        if (int.TryParse(input, out int output)) {
            int input2 = int.Parse(input);
            Console.WriteLine("Deine Zahl wurde um 1 vergrößert: ");
            Console.Write(input2 + 1);
        }
    if (input == "Beenden") {
        isInput = false;
    }
}

