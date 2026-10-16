using System;

namespace cSharpFundamentals._07_Math
{
    public class MathExample
    {
        public static void _Math_(string []args)
        {
            //C# sadrži mnoge metode koje omogućuju izvođenje matematičkih operacija nad brojevima.
            //C# ima sljedece Math metode: Max, Min, Sqrt, Abs i Abs ima ih više ali za sada učimo samo ove.
            
            int a = 5;
            int b = 10;
            
            int c = 15;
            int d = 20;
            
            int e = 64; 
            float f = 9.76f;
            int g = -10;
            
            Console.WriteLine(Math.Max(a, b)); //Math.Max vraca veci broj izmedu dva broja
            Console.WriteLine(Math.Min(c, d)); //Math.Min vraca manji broj izmedu dva broja
            Console.WriteLine(Math.Sqrt(e)); //Math.Sqrt vraca korjen jednog broja
            Console.WriteLine(Math.Round(f)); //Math.Round vraca broj zaokružen na najblizi cijeli broj
            Console.WriteLine(Math.Abs(g)); //Vraća apsolutno pozitivanu vrijednost od broja.
            
            
            
            
        }
    }
}