using System;

namespace cSharpFundamentals._16_Metode
{
    public class DefaultParameterValue
    {

        static void MyMethod(string country = "Norway") // Ovdje smo stavili defaultnu vrijednost parametra "country" sa znakom = 
        {
            Console.WriteLine(country);// ovu radnju izvrsava kada pozovemo metodu MyMethod
        }
        public static void DefaultParameterValueExample()
        {
            
            MyMethod("India"); // ispisuje "India"
            MyMethod("Croatia"); // ispisuje "Croatia"
            MyMethod(); // ispisuje "Norway" jer je to defaultna vrijednost parametra "country"
            
            //Mala napomena ako koristimo vise parametara u metodi parametar koji ima default vrijednost ide na kraju.
            
        }
    }
}