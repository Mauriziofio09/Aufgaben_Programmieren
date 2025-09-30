using System;

class Program
{
    static void Main(string[] args)
    {
        int laenge;

        Console.WriteLine("Wie lang soll die Linie sein?");
        Console.Write("Deine Eingabe: ");
        
        if (int.TryParse(Console.ReadLine(), out laenge))
        {
            for (int i = 0; i < laenge; i++)
            {
                for (int j = 0; j < laenge; j++)
                {
                    if (i == 0 || i == laenge - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j == i)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}