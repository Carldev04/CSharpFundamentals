using System;

namespace cSharpFundamentals._15_Nizovi
{
    public class LoopThroughArrays
    {
        public static void LoopThroughArraysExample(string[] args)
        {
            //Pomoću petlji možemo preći preko svih elemenata niza.
            //Imamo dvije vrste petlji koje se koriste za prolazak kroz nizove: for i foreach.
            
            //for petlja koristi brojac i (obicno varijablu i) i svojstvo length da petlja zna koliko se puta treba vrteti.

            string[] cars = {"Volvo", "BMW", "Mazda", "Ford"};
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]); //petlja se ponavlja koliko ima elemenata u nizu.
            }
            
            //foreach petlja je moderniji način vrslo slican for petlji ali foreach nema brojac i ne koristi svojstvo length.

            string[] fruits = {"Banana", "Apple", "Blueberry", "Mango"};
            foreach (string b in fruits)
            {
                Console.WriteLine(b);//isto prolazi kroz sve elemente niza.
            }
        }
    }
}