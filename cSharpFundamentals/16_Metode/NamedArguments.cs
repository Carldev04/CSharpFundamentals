using System;

namespace cSharpFundamentals._16_Metode
{
    public class NamedArguments
    {
        static void MyMethod(string dijete1, string dijete2, string dijete3)
        {
            Console.WriteLine("Najmladje dijete je " + dijete3); //Ovo metoda izvrsava
        }
        
        public static void NamedArgumentsExample (string[] args)
        {
            //Takodjer je moguce proslijediti vrijednosti parametrima metode koristeci nazive parametara umjesto pozicija.
            //Ovom metodom nije bitan redosljed parametara i argumentima 
            //prati format parametar: vrijednost.
            
            MyMethod(dijete1: "Marko", dijete2: "Ivan", dijete3: "Ana");// ovdje pozivamo metodu i dodjelujemo vrijednosti parametrima.
            
            //najmladje dijete je Ana
        }
    }
}