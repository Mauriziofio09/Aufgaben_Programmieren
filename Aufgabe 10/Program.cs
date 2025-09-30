Console.WriteLine("Gib mir eine Zahl: ");
string eingabe = Console.ReadLine();

int quersumme = 0;

foreach (char ziffer in eingabe)
{
    if (char.IsDigit(ziffer))
    {
        quersumme += (ziffer - '0');
    }
    
        
}

Console.WriteLine($"Die Quersumme von {eingabe} ist {quersumme}");