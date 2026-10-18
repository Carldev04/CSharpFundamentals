using System;

namespace cSharpFundamentals._09_Booleans
{
    public class Booleans
    {
        public static void BooleansExample(string []args)
        {
            //Boolean izraz usporedjuje dvije varijable pomocu logicki operatora usporedbe i tako dobijemo vrijedno true ili false
            
            int x = 10;
            int y = 5;
            Console.WriteLine(x > y); //ispisuje true
            
            //Primjer iz realnog života. 

            int myAge = 20;
            int votingAge = 18;
            Console.WriteLine(myAge >= votingAge);
            
            //Jos bolji primjer kroz if statement

            if (myAge >= votingAge)
            {
                Console.WriteLine("You are old enough to vote");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote");
            }




        }
    }
}