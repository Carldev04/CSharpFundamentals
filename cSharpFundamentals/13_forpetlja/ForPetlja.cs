using System;

namespace cSharpFundamentals._13_forpetlja
{
    public class ForPetlja
    {
        public static void ForPetljaExample(string []args)
        {
            //Kada točno znate koliko puta želite ponoviti blok koda, upotrijebite `for` petlju umjesto `while` petlje.
            
            //for (statement 1; statement 2; statement 3)// 

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            
            /*
             Izraz 1 postavlja varijablu prije početka petlje (int i = 0).

             Izraz 2 definira uvjet za izvođenje petlje (i mora biti manji od 5). Ako je uvjet istinit, petlja će se ponovno pokrenuti; ako je neistinit, petlja će završiti.

             Izraz 3 povećava vrijednost (i++) svaki put nakon što se izvrši blok koda unutar petlje.
             */
            
            //Nested for petlje
            
            //Također je moguće postaviti jednu petlju unutar druge. To se naziva ugniježđena petlja.
            //utarnja petlja” izvršit će se jednom za svaku iteraciju „vanjske petlje”:

            for (int b = 1; b <= 2; b++)
            {
                Console.WriteLine("Outer: " + b);

                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("Inner: " + j);
                }
            }
        }
    }
}