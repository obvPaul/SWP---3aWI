using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Bitte geben Sie einen Wert ein:");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out bool boolValue)) {
            Console.WriteLine($"Der eingegebene Wert ist vom Typ: Bool (Wahr/Falsch)");
            Console.WriteLine($"Initialisierte Variable: {boolValue}");
        }
        else if (int.TryParse(input, out int intValue)) {
            Console.WriteLine($"Der eingegebene Wert ist vom Typ: Integer (Ganzzahl)");
            Console.WriteLine($"Initialisierte Variable: {intValue}");
        }
        else if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double doubleValue)) {
            Console.WriteLine($"Der eingegebene Wert ist vom Typ: Double (Kommazahl)");
            Console.WriteLine($"Initialisierte Variable: {doubleValue}");
        }
        else if (DateTime.TryParse(input, out DateTime dateValue)) {
            Console.WriteLine($"Der eingegebene Wert ist vom Typ: Datum");
            Console.WriteLine($"Initialisierte Variable: {dateValue.ToShortDateString()}");
        }
    }
}

