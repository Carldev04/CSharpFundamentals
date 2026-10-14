using System;

namespace cSharpFundamentals
{
    public class DisplayVariables
    {
        public static void _DisplayVariables_(string[] args)
        {
            //WriteLine metodu koristimo za ispisivanje na konzolu.
            
            //Ali da bi kombinirali tekst i varijable koristimo +
            
            string name = "John";
            Console.WriteLine("Hello " + name);
            
            //Mozemo koristit + kada spajamo dvije varijable 
            string firstName = "John";
            string lastName = "Allison";
            string fullName = firstName + lastName;
            Console.WriteLine("Full name: " + fullName);
            
            //operator + radi takodjer kada zbarajmo dva broja. 
            int x = 10;
            int y = 20;
            Console.WriteLine(x + y);

        }
    }
}