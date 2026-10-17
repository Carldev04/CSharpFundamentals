using System;

namespace cSharpFundamentals._08_StringExamples
{
    public class AccessStrings
    {
        public static void AccessStringsExample (string[] args)
        {
            //Znakovima u nizu jednog stringa možemo pristupiti koristeći indeksiranje njehovih brojeva u [] zagradama index pocinje od 0.
            //Ovaj primjer ispisuje prvo slovo u varijabli myString 

            string myString = "Hello World";
            Console.WriteLine(myString[0]); //ispisuje slovo H.
            
            Console.WriteLine(myString[1]); //ispisuje slovo e.
            
            //Kada zelimo pronaci npr gdje se u stringu nalizi neki karakter koristimo IndexOf() metodu.
            Console.WriteLine(myString.IndexOf('o')); //ispisuje broj 4 jer je slovo o na 4. mjestu u stringu.
            
            //Ako u slucaju da imamo vise istih karatera u varijabli onda C# ispisuje prvi index broj koji dolazi do tog slova
            Console.WriteLine(myString.IndexOf('l')); //ispisuje broj 2 jer je slovo l pojavljuje prvi put na 2. mjestu,
            
            //Imamo i metodu SubString() koja fukcionira tako da uzmem0 jedno slovo iz varijable,
            //onda ce ta metoda da izbrise sva slova do tog slova u varijabli

            string myString2 = "Karlo Jozic";
            int charPos = myString2.IndexOf('J');
            Console.WriteLine(myString2.Substring(charPos)); //Kod ispisuje Jozic




        } 
    }
}