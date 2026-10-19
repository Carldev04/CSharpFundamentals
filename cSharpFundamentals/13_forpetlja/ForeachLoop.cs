using System;

namespace cSharpFundamentals._13_forpetlja
{
    public class ForeachLoop
    {
        public static void ForeachLoop_Example()
        {
            //Postoji i `foreach` petlja, koja se koristi isključivo za prolazak kroz elemente u array (ili drugim skupovima podataka):
            
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            
            foreach (string i in cars)
            {
                Console.WriteLine(i); //ispisuje sve elemente u polju `cars` koristeći petlju `foreach`:
            }
            
        }
    }
}