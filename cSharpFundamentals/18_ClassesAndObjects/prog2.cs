using System;

namespace cSharpFundamentals._18_ClassesAndObjects
{
    public class prog2
    {
        public static void prog2Example (string[] args)
        {
            Car myCar = new Car(); //kreirali objekt
            Car mySecondCar = new Car(); //kreirali drugi objekt
            
            Console.WriteLine(myCar.color); //ispisuje white koji smo deklarirali u prog.cs
            Console.WriteLine(mySecondCar.color); //ispisuje white koji smo deklarirali u prog.cs
        }
    }
}