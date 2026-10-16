using System;

namespace cSharpFundamentals._08_StringExamples
{
    public class typeOfString
    {
        public static void Strings(string []args)
        {
            //String moze imati koliko zelimo karaktera ili slova izmedju navodnika. 
            //Danas radimo o string metodama neki od njih su: length, toUpper i toLower.
            
            string greeting = "Ovo je paragraf i on se sastoji od riječi";
            string greeting2 = "Danas je lijep dan";
            string greeting3 = "u ovom paragrafu ce biti samo mala slova";
            
            Console.WriteLine("broj slova u stringu greeting je: " + greeting.Length);
            Console.WriteLine("string greeting2 ce se ispisati u velikim slovima: " + greeting2.ToUpper());
            Console.WriteLine("string greeting3 ce se ispisati u malim slovima: " + greeting3.ToLower());
        }
    }
}