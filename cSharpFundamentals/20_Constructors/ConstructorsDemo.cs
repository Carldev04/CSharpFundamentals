using System;

namespace cSharpFundamentals._20_Constructors
{
    public class ConstructorsDemo
    {
        public static void prog2Example(string[] args)
        {
           Car myCar = new Car("ModelX", "Red", 2022);
           Console.WriteLine(myCar.model + " " + myCar.color + " " + myCar.year);
        }
    }
}