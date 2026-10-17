using System;

namespace cSharpFundamentals._08_StringExamples
{
    public class StringInterpolation
    {
        public static void StringInterpolationExample() 
        { 
            //Još jedna mogućnost spajanja nizova jest interpolacija nizova, pri čemu se vrijednosti varijabli umeću na mjesta rezervirana za njih unutar niza.
            //Pritom ne morate voditi računa o razmacima, kao što je to slučaj kod spajanja nizova:
            
            //Pomocu interpolacije mozemo lakse manipulirati strigovima a da to izgleda čistije.

            string name = "John";
            string lastName = "Doe";
            string fullName = $"My full name is: {name} {lastName}";
            Console.WriteLine(fullName);
            
            //Na ovaj način interpolacija nizova omogućava lakše manipulaciju stringova i čisti kod.
            
        }
    }
}