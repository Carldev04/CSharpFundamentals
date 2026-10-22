using System;

namespace cSharpFundamentals._16_Metode
{
    public class Metode
    {
        public static void MetodeExample(string[] args)
        {
            //Metoda je blok koda koji se izvrsava kada se pozove.
            //U metodu možemo prosljediti podatke poznate kao parametri.
            //Metode se koriste za izvodjenje odredjenih radnji
            
            MyMethod(); //ispisuje Hello Method.
            
        }
        
        static void MyMethod() 
        {
            Console.WriteLine("Hello Method");
            //MyMethod je naziv metode.
            //Static znaci da pripada klasi a ne nekom objektu ili instanci klase.
            //Void znaci da metoda ne vraca nikakav rezultat.
        }
    }
}