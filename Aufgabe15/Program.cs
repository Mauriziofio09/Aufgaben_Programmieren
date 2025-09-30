   Console.WriteLine("Breite des Stammes?");
   int breite = Convert.ToInt32(Console.ReadLine());
   
   Console.WriteLine("Höhe des Stammes?");
   int höhe = Convert.ToInt32(Console.ReadLine());
   
   Console.WriteLine("Höhe der Krone?");
   int crown = Convert.ToInt32(Console.ReadLine());
   
   if (int.TryParse(Console.ReadLine(), out höhe))
   {
       for (int i = 0; i < höhe; i++)
       {
           for (int j = 0; j < höhe; j++)
           {
               if (i == 0 || i == höhe - 1)
               {
                   Console.Write("*");
               }
               else
               {
                   if (j == i)
                   {
                       Console.Write(" ");
                   }
                   else
                   {
                       Console.Write("*");
                   }
               }
           }
           Console.WriteLine();
       }
   }