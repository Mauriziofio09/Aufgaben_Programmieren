int giveMonth;

Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekunden berechnen wollen? (Nur 28,29,30,31)");

string input = Console.ReadLine();

if (int.TryParse(input, out giveMonth) && (giveMonth == 28 || giveMonth == 29 || giveMonth == 30 || giveMonth == 31))
{
    Console.WriteLine("Ihre Eingabe " + giveMonth + " ist gültig.");
    double seconds = giveMonth * 86400.0;
    Console.WriteLine("Dein Monat mit " + giveMonth + " Tagen hat " + seconds + " Sekunden.");
}
else
{
    Console.WriteLine("Eingabefehler. Bitte geben Sie eine gültige Zahl ein.");
}