
        Console.WriteLine("Prüfen ob es sich bei einem Jahr um ein Schaltjahr handelt.");
        Console.WriteLine("***********************************************************");

        while (true)
        {
            Console.Write("Eingabe Jahr (q zum Beenden): ");
            string input = Console.ReadLine();

            if (input == "q" || input == "Q")
                break;

            if (int.TryParse(input, out int year))
            {
                if (DateTime.IsLeapYear(year))
                    Console.WriteLine("Das Jahr " + year + " ist ein Schaltjahr.");
                else
                    Console.WriteLine("Das Jahr " + year + " ist KEIN Schaltjahr.");
            }
            
        }