using System;

namespace cSharpFundamentals._10_IfElse
{
    public class ifElseStatement
    {
        public static void ifElseStatementExample(string[] args)
        {
            //else koristimo kada treba izvrsiti odredjeni kod ako se uvjet ne ispunjava.
            if (20 > 10)
            {
              Console.WriteLine("OVaj uvjet je ispunjen.");  
            }
            else
            {
              Console.WriteLine("OVaj uvjet nije ispunjen.");  
            }
            
            //Primjer sa varijablama 

            int time = 20;
            if (time >= 19)
            {
                Console.WriteLine("Vrijeme je za spavanje");
            }
            else
            {
                Console.WriteLine("Vrijeme nije za spavanje");
            }
            
        }
    }
}