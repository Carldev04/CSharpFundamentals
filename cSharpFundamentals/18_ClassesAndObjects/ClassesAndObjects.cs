using System;

namespace cSharpFundamentals._18_ClassesAndObjects
{
    public class ClassesAndObjects
    {

        class Car //Kreoramo klasu Car
        { 
            string color = "red"; //string color u clasi car predstavlja polje.
        }
        public static void ClassesAndObjectsExample(string[] args)
        {
            Car myCar = new Car(); //struktura pravljenja objektra: naziv klase + ime objekta = new naziv klase();
            Console.WriteLine(myCar.color);
        }
    }
}