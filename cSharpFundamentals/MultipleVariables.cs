using System;

namespace cSharpFundamentals
{
    public class MultipleVariables
    {
        public static void _MultipleVariables_(string[] args)
        {
            //Da bi neklalorali vise varijabli od jednom moramo imati varijable istog tipa i svaku varijablu odvojiti zarezom.
            int x = 10, y = 15, z = 20;
            Console.WriteLine(x + y + z);
            
            //Mozemo takodjer dodati iste vrrijednosti  na vise varijabli
            int a, b, c;
            a = b = c = 50;
            Console.WriteLine(a + b + c);
        }
    }
}