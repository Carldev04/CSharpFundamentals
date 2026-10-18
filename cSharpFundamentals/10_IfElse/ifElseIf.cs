using System;

namespace cSharpFundamentals._10_IfElse
{
    public class ifElseIf
    {
        public static void ifElseIfExample(string []args)
        {
            //else if koristimo kako bismo naveli novi uvjet ako je prvi uvjet netočan.
            
            int time = 10;

            if (time > 12)
            {
                Console.WriteLine("Good afternoon.");
            }
            else if (time > 11)
            {
                Console.WriteLine("Good afternoon again.");
            }
            else 
            {
                Console.WriteLine("Good evening.");
            }
        }
    }
}