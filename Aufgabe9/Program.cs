Console.WriteLine("Gebe mir eine Dezimal Zahl: ");
int dez = Convert.ToInt32(Console.ReadLine());

     string binary = Convert.ToString(dez, 2);
    Console.WriteLine("Die Binäre Darstellung von " + dez + " ist " + binary);


