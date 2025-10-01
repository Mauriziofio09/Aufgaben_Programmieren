using System;

class Weihnachtsbaum
{
    static void Main()
    {
        Console.Write("Breite des Stammes? ");
        int stammBreite = int.Parse(Console.ReadLine());

        Console.Write("Höhe des Stammes? ");
        int stammHoehe = int.Parse(Console.ReadLine());

        Console.Write("Höhe der Krone? ");
        int kroneHoehe = int.Parse(Console.ReadLine());

        // Krone
        for (int i = 1; i <= kroneHoehe; i++)
        {
            // Leerzeichen für zentrieren
            for (int j = 0; j < kroneHoehe - i; j++)
                Console.Write(" ");

            // Sterne
            for (int j = 0; j < 2 * i - 1; j++)
                Console.Write("*");

            Console.WriteLine();
        }

        // Stamm
        for (int i = 0; i < stammHoehe; i++)
        {
            for (int j = 0; j < kroneHoehe - stammBreite / 2 - 1; j++)
                Console.Write(" ");

            for (int j = 0; j < stammBreite; j++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
}