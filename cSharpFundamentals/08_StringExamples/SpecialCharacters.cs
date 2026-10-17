using System;

namespace cSharpFundamentals._08_StringExamples
{
    public class SpecialCharacters
    {
        public static void SpecialCharactersExample(string[] args)
        {
            //Strigovi u c# se uvijek pisu u navodnicima i onda kada nas tekst ima navodnike dolazi do greske i onda moramo 
            //kompjleru objasniti da mora ignorirati te navodnike da trazi nove. 
            //Da bi rijesili ovaj problem koristimo backslash.

            string txt = "We are called \\Vikings\\ from the north"; //ispisuje backslash 
            string txt2 = "We are called \"Vikings\" from the north"; //ispisuje navodnike dvostruke
            string txt3 = "We are called \'Vikings\' from the north"; //ispisuje navodnike jednostruke
            Console.WriteLine(txt);
            Console.WriteLine(txt2);
            Console.WriteLine(txt3);
            
            //ostali korisni savjeti za stringove
            //\n	New Line	
            //\t	Tab	
            //\b	Backspace

        }
    }
}