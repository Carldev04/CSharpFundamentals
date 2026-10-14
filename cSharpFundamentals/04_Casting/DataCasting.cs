using System;

namespace cSharpFundamentals._04_Casting
{
    public class DataCasting
    {
        public static void _DataCasting_(string[] args)
        {
            //Casting je proces pretvaranja jednog tipa podataka u drugi tip podataka.
            //U C# imamo dvije vrste castinga: implicitni i explicitni. 
            
            //Implicitna pretvorba (automatska) – pretvaranje tipa manje veličine u tip veće veličine
            //char -> int -> long -> float -> double
            
            //Explicit Casting (manually) - converting a larger type to a smaller size type
            //double -> float -> long -> int -> char
            
            //Implicit Casting
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            
            //Explicit Casting
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2; //Manualna pretvorba iz double u int.
            
            Console.WriteLine(myDouble2); //output je 9.78
            Console.WriteLine(myInt2); //output je 9
            
            //Metode pretvorbe tipova
            
            //Također je moguće eksplicitno pretvoriti tipove podataka pomoću ugrađenih metoda,
            //kao što su Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) i Convert.ToInt64 (long):

            int myInt3 = 10;
            double myDouble3 = 5.75;
            bool myBool = true;
            
            Console.WriteLine(Convert.ToString(myInt3)); //pretvara vrijednost 10 u String
            Console.WriteLine(Convert.ToInt32(myDouble3)); //pretvara vrijednost 5.75 u int
            Console.WriteLine(Convert.ToDouble(myInt3)); //pretvara vrijednost 10 u double
            Console.WriteLine(Convert.ToString(myBool)); //pretvara vrijednost true u String

        }
    }
}