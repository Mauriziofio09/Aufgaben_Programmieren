class Program
{
    static void Main()
    {

        int zahl1;
        int zahl2;

        Console.WriteLine("Gebe mir Zahl Nr. 1: ");
        zahl1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Gebe mir Zahl Nr. 2: ");
        zahl2 = Convert.ToInt32(Console.ReadLine());

        double sum = zahl1 +  zahl2;
        Console.WriteLine("Die Summe deiner Zahlen ist: " + sum);
    }
    
}