using System;

namespace cSharpFundamentals._22_Properties
{
    class Person2
    {
        public string Name { get; set; }//mozemo primjetit da nismo napravili privatno polje "name" jer smo napravili samo properti koji mora imati prvo pocetno slovo od polja.
                                        //Zato C# predpostavlja posto smo napravili properti Name da nam je automatski napravio privatno polje "name" zato se zove automatic property
    }
    
    public class AutomaticProperties_ShortHand
    {
        public static void AutomaticProperties_ShortHandExample(string[] args)
        {
            //C# nam omogucava da kreiramo properti bez potrebe za definisanjem privatnog polja. sve u jednoj liniji kreiranje polja i propertija.
            //Radi kod a imamo manje spaggeti koda.
            
            Person2 personIspis = new Person2();//kreiramo objekt
            personIspis.Name = "Luka"; //dodajemo vrijednost propertiju
            Console.WriteLine(personIspis.Name);//ispisuje Luka.
            
            //takodjer mozemo koristit samo get ili samo set:
            //Ako koristimo samo get metodu korisniku damo da samo moze citat podatke. 
            //Ako koristimo samo set metodu korisniku damo da samo moze pisat podatke ali ne i citat.
            
        }
    }
}