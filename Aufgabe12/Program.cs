using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.Write("Geben Sie die zu summierenden Ganzzahlen mit Komma getrennt ein: ");

        string input = Console.ReadLine();

        string[] numberStrings = input.Split(',');

        Console.WriteLine("Resultat:");

        int runningSum = 0;
        var results = new List<string>();

        for (int i = 0; i < numberStrings.Length; i++)
        {
            if (int.TryParse(numberStrings[i].Trim(), out int currentNumber))
            {
                runningSum += currentNumber;

                results.Add($"[{i}] -> {runningSum}");
            }
            else
            {
                Console.WriteLine($"'{numberStrings[i]}' ist keine gültige Zahl und wird ignoriert.");
            }
        }

        Console.WriteLine(string.Join(", ", results));
    }
}