using System;

namespace cSharpFundamentals._08_StringExamples
{
    public class StringConcatenation
    {
        public static void StringConcatenationExample ()
        {
            //Operator + može se koristiti između nizova znakova kako bi ih se spojilo. To se naziva konkatenacija:
            //Ali mozemo koristit metodu String.Concat() za konkatenaciju nizova znakova:
            
            string firstName = "John";
            string lastName = "Doe";
            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine(fullName);
            
            //Ne smijemo operator + kada zelimo spojiti dva stringa. Ako pokusamo to dva stringa ce se spojiti kao jedan string.

            string x = "10";
            string y = "20";
            string z = x + y;
            Console.WriteLine(z);
            
            //Rezultat nije 30 jer se radi o stringu kao tip podatka ipak ako ako su brojevi uspisani.
            
            int x1 = 10;
            int y1 = 20;
            int z1 = x1 + y1;
        }
    }
}