int giveMonth;
string input = Console.ReadLine();

Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekunden berechnen wollen?");
giveMonth = Convert.ToInt32(Console.ReadLine());


if (int.TryParse(input, out int value) && (value == 28 || value == 29 || value == 30 || value == 31))
{
    Console.WriteLine("Ihre Eingabe " + value + " ist gültig.");
    double seconds = giveMonth * 86400.0;
    Console.WriteLine("Dein Monat mit " + giveMonth + " Tagen " + seconds);
}
else
{
    int giveMonth1;
    Console.WriteLine("Eingabefehler. Bitte geben Sie eine gültige Zahl ein.");
    Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekunden berechnen wollen? {Nur 28,29,30,31}");
    giveMonth1 = Convert.ToInt32(Console.ReadLine());
    double seconds = giveMonth1 * 86400.0;
    Console.WriteLine("Dein Monat mit " + giveMonth + " Tagen " + seconds);
    
}



