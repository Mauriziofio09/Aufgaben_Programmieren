using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bitte einen Text eingeben:");
        string input = Console.ReadLine();

        char[] vokale = { 'a', 'e', 'i', 'o', 'u', 'ä', 'ö', 'ü', 
            'A', 'E', 'I', 'O', 'U', 'Ä', 'Ö', 'Ü' };

        Dictionary<char, int> zaehlung = new Dictionary<char, int>();

        foreach (char v in vokale)
        {
            zaehlung[v] = 0;
        }

        foreach (char c in input)
        {
            if (zaehlung.ContainsKey(c))
            {
                zaehlung[c]++;
            }
        }

        int total = 0;
        foreach (var item in zaehlung)
        {
            total += item.Value;
        }

        Console.WriteLine("\nErgebnisse:");
        Console.WriteLine("Gesamtanzahl Vokale: " + total);

        foreach (var item in zaehlung)
        {
            if (item.Value > 0)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        Console.WriteLine("\nDrücke eine Taste zum Beenden...");
        Console.ReadKey();
    }
}