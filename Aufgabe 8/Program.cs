
        string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" };

        Console.WriteLine("Bitte Kommentar eingeben:");
        string comment = Console.ReadLine();

        bool containsForbidden = false;

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            if (comment.Contains(forbiddenWords[i], StringComparison.OrdinalIgnoreCase))
            {
                containsForbidden = true;
                break;
            }
        }

        if (containsForbidden)
        {
            Console.WriteLine("Kommentar wird nicht veröffentlicht");
        }
        else
        {
            Console.WriteLine("Ein schöner Kommentar ohne Böswilligkeiten.");
        }