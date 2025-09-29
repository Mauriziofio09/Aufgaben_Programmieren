using System.ComponentModel.Design;

Console.WriteLine("Eine Zahl (1-12): ");
int month =  Convert.ToInt32(Console.ReadLine());

switch (month)
{
case 1: Console.WriteLine("Januar"); break;
case 2: Console.WriteLine("Februar"); break;
case 3: Console.WriteLine("Mars"); break;
case 4: Console.WriteLine("April"); break;
case 5: Console.WriteLine("May"); break;
case 6: Console.WriteLine("June"); break;
case 7: Console.WriteLine("July"); break;
case 8: Console.WriteLine("August"); break;
case 9: Console.WriteLine("September"); break;
case 10: Console.WriteLine("October"); break;
case 11: Console.WriteLine("November"); break;
case 12: Console.WriteLine("December"); break;
}

if (month > 12)
{
    Console.WriteLine("Fehler");
}