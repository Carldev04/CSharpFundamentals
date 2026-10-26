using System;

namespace cSharpFundamentals._18_ClassesAndObjects
{
    public class MultipleClassesAndObjects
    {
        class Car// kreiramo klasu Car
        {
            public string color = "red"; //dodjelili smo joj varijablu ili polje
        }
        
        public static void MultipleClassesAndObjectsExample(string[] args)
        {
            //Koristenje vise objekata u jednoj klasi.
            Car myCar = new Car(); //prvi objekt
            Car mySecoundCar = new Car(); //drugi objekt.
            
            Console.WriteLine("Moje auto je: " + myCar.color + " boje");
            Console.WriteLine("Moje drugo auto je: " + mySecoundCar.color + " boje");
 
        }
    }
}