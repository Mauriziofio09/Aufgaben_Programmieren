using System;

class Taschenrechner
{
    static void Main()
    {
        Console.WriteLine("Einfacher Taschenrechner (Format: Zahl Operator Zahl)");

        while (true)
        {
            Console.Write("\nGib deinen Ausdruck ein (oder 'exit' zum Beenden): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            try
            {
                string cleanedInput = input.Replace(" ", "");

                double zahl1 = 0, zahl2 = 0;
                char op = '\0';
                bool operatorGefunden = false;

                foreach (char c in cleanedInput)
                {
                    if (c == '+' || c == '-' || c == '*' || c == '/')
                    {
                        op = c;
                        operatorGefunden = true;
                        break;
                    }
                }

                if (!operatorGefunden)
                {
                    Console.WriteLine("Kein gültiger Operator gefunden!");
                    continue;
                }

                string[] teile = cleanedInput.Split(op);

                if (teile.Length != 2)
                {
                    Console.WriteLine("Ungültiger Ausdruck!");
                    continue;
                }

                if (!double.TryParse(teile[0], out zahl1) || !double.TryParse(teile[1], out zahl2))
                {
                    Console.WriteLine("Ungültige Zahleneingabe!");
                    continue;
                }

                double ergebnis = 0;
                switch (op)
                {
                    case '+':
                        ergebnis = zahl1 + zahl2;
                        break;
                    case '-':
                        ergebnis = zahl1 - zahl2;
                        break;
                    case '*':
                        ergebnis = zahl1 * zahl2;
                        break;
                    case '/':
                        if (zahl2 == 0)
                        {
                            Console.WriteLine("Fehler: Division durch Null!");
                            continue;
                        }
                        ergebnis = zahl1 / zahl2;
                        break;
                }

                Console.WriteLine($"Ergebnis: {ergebnis}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
        }
    }
}
