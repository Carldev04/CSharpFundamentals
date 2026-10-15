using System;

namespace cSharpFundamentals._06_Operators
{
    public class LogicalOperators
    {
        public static void _LogicalOperators_(string []args)
        {
            //Kao i kod operatora usporedbe, pomoću logičkih operatora također možete provjeriti vrijednosti True ili False.
            //Logički operatori koriste se za određivanje logičkog odnosa između varijabli ili vrijednosti:
            
            //operator && vraća true ako su oba izraza točna
            //operator || vraća true ako je bar jedan izraz točan
            //operator ! vraća true ako je izraz netočan i vraća netočno kada je izraz točan (reverse)

            int x = 5;
            Console.WriteLine(x > 3 && x < 8);
        }
    }
}