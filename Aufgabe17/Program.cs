using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nGib dein Geburtsdatum ein (Format: TT.MM.JJJJ): ");
        string eingabe = Console.ReadLine();

        if (DateTime.TryParse(eingabe, out DateTime geburtsdatum))
        {
            DateTime heute = DateTime.Today;

            int jahre = heute.Year - geburtsdatum.Year;
            int monate = heute.Month - geburtsdatum.Month;
            int tage = heute.Day - geburtsdatum.Day;

            if (tage < 0)
            {
                monate--;
                DateTime letzterMonat = heute.AddMonths(-1);
                tage += DateTime.DaysInMonth(letzterMonat.Year, letzterMonat.Month);
            }

            if (monate < 0)
            {
                jahre--;
                monate += 12;
            }

            TimeSpan gesamt = heute - geburtsdatum;
            int wochen = gesamt.Days / 7;

            Console.WriteLine($"Alter in Jahren: {jahre}");
            Console.WriteLine($"Alter in Monaten : {monate}");
            Console.WriteLine($"Alter in Wochen : {wochen}");
            Console.WriteLine($"Alter in Tagen : {tage}");
        } 
    }
}