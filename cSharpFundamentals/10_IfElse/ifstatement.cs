using System;

namespace cSharpFundamentals._10_IfElse
{
    public class ifstatement
    {
        public static void ifstatementExample(string[] args)
        {
            //C# ima sljedece uvjete
            //if, else, else if i switch.
            //if uvjet koristimo kada treba izvrsiti odredjeni kod ako se uvjet ispunjava.

            if (20 > 10)
            {
                Console.WriteLine("Ovaj uvjet je ispunjen.");
            }
            
            //Ovo mozemo takodjer raditi sa varijablama.
            
            int x = 20;
            int y = 10;

            if (x > y)
            {
                Console.WriteLine("Ovaj uvjet je ispunjen.");
            }
        }
    }
}