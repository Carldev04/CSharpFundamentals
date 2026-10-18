using System;

namespace cSharpFundamentals._10_IfElse
{
    public class ShortHandIfElse
    {
        public static void ShortHandIfElseExample(string[] args)
        {
            //Postoji i skraćeni oblik `if-else` konstrukcije, poznat kao ternarni operator,
            //budući da se sastoji od tri operanda. Može se koristiti za zamjenu više redaka koda jednim retkom.
            //Često se primjenjuje kao zamjena za jednostavne `if-else` naredbe:
            
            //Sytaxa je sljedeća: variable = (condition) ? expressionTrue :  expressionFalse;

            int time = 24;
            string result = (time > 11) ? "Good afternoon again:" : "Good evening.";
            Console.WriteLine(result);
        }
    }
}