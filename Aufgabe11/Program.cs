Console.Write("Zahl 1: ");
int eingabe1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Zahl 2: ");
int eingabe2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Zahl, Quersumme, Zahl/Quersumme");

for (int i = eingabe1; i <= eingabe2; i++)
{
    int quersumme = 0;
    foreach (char ziffer in i.ToString())
    {
        quersumme += (ziffer - '0');
    }

    double divide = (double)i / quersumme;

    if (i % quersumme == 0)
    {
        Console.WriteLine($"{i}, {quersumme}, {divide}");
    }
}