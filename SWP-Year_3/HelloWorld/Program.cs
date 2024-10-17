﻿using System;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine($"Geben Sie die benötigte Zahl ein für Ihre gewünschte Mathematische Berechnung:\n1 zum Multiplizieren\n2 zum Dividieren\n3 zum Addieren\n4 zum Potenzieren\n5 zum Wurzelziehen\n6 zum Fakultieren\n7 zum Invertieren");
string Eingabe = Console.ReadLine();
int Rechnung;
int Nummer1;
int Nummer2;
bool Nummer = int.TryParse(Eingabe, out Rechnung);

if (Nummer == true) {
    if (Rechnung == 1) {
        Console.WriteLine("Geben Sie Ihre erste Zahl ein");
            int.TryParse(Console.ReadLine(), out Nummer1);
        Console.WriteLine("Geben Sie nun Ihre zweite Zahl ein");
            int.TryParse(Console.ReadLine(), out Nummer2);
        Console.WriteLine("Ihr Ergebnis lautet: " + Nummer1 * Nummer2);
    } 
    else if (Rechnung == 2) {
        Console.WriteLine("Geben Sie Ihre erste Zahl ein");
            int.TryParse(Console.ReadLine(), out Nummer1);
        Console.WriteLine("Geben Sie nun Ihre zweite Zahl ein");
            int.TryParse(Console.ReadLine(), out Nummer2);
        Console.WriteLine("Ihr Ergebnis lautet: " + Nummer1 / Nummer2);
    } 
    else if (Rechnung == 3) {
        Console.WriteLine("Geben Sie Ihre erste Zahl ein");
            int.TryParse(Console.ReadLine(), out Nummer1);
        Console.WriteLine("Geben Sie nun Ihre zweite Zahl ein");
            int.TryParse(Console.ReadLine(), out Nummer2);
        int Addition = Nummer1 + Nummer2;
        Console.WriteLine("Ihr Ergebnis lautet: " + Addition);
    } 
    else if (Rechnung == 4) {
        Console.WriteLine("Geben Sie Ihre erste Zahl ein");
            int.TryParse(Console.ReadLine(), out Nummer1);
        Console.WriteLine("Geben Sie nun Ihre zweite Zahl ein");
            int.TryParse(Console.ReadLine(), out Nummer2);
        Console.WriteLine("Ihr Ergebnis lautet: " + Math.Pow(Nummer1, Nummer2));
    } 
    else if (Rechnung == 5) {
        Console.WriteLine("Geben Sie Ihre erste Zahl ein");
            int.TryParse(Console.ReadLine(), out Nummer1);
        Console.WriteLine("Ihr Ergebnis lautet: " + Math.Sqrt(Nummer1));
    } 
    else if (Rechnung == 6) {
        Console.WriteLine("Geben Sie Ihre erste Zahl ein");
            int.TryParse(Console.ReadLine(), out Nummer1);
        double fakultaet = 1;
        for (int i = 1; i <= Nummer1; i++) {
            fakultaet *= i;
        }
        Console.WriteLine("Ihr Ergebnis lautet: " + fakultaet);
    } 
    else if (Rechnung == 7) {
        Console.WriteLine("Geben Sie Ihre erste Zahl ein");
            int.TryParse(Console.ReadLine(), out Nummer1);
        Console.WriteLine("Ihr Ergebnis lautet: " + -Nummer1);
    } 
    else {
        Console.Write("Sie haben keine gültige Zahl eingegeben");
    }
}
else {
    Console.Write("Sie haben keine gültige Zahl eingegeben");
}