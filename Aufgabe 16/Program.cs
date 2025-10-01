using System;

class Program
{
    static void Main()
    {
        bool running = true;
        Random rnd = new Random();

        while (running)
        {
            int secret = rnd.Next(1, 101);
            int guess = 0;
            int tries = 0;

            Console.WriteLine("Ich habe eine Zahl zwischen 1 und 100. Rate sie!");

            while (guess != secret)
            {
                Console.Write("Dein Tipp: ");
                guess = int.Parse(Console.ReadLine());
                tries++;

                if (guess > secret)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner");
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Die gesuchte Zahl ist grösser");
                }
                else
                {
                    Console.WriteLine($"\nDu hast die Zahl in {tries} Versuchen erraten!");
                    Console.Write("Möchtest du nochmal spielen (g) oder das Programm beenden (q)? ");

                    string choice = Console.ReadLine().ToLower();
                    if (choice == "q")
                    {
                        running = false;
                    }
                    else if (choice == "g")
                    {
                        Console.WriteLine("\nNeues Spiel startet...\n");
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Programm beendet.");
                        running = false;
                    }
                }
            }
        }
    }
}