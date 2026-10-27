using System;

namespace cSharpFundamentals._20_Constructors
{
    public class Constructors_2
    {

        public class Car //Kreiranje klase Car
        {
            public string Model; 
            public string Color; //kreiranje 3 varijabli: Model, Color, Year.
            public int Year;

            public Car(string modelName, string modelColor, int modelYear)//Kreiranje konstruktora i sa 3 parametra 
            {
                Model = modelName; //Varijabla Model je sada jednaka parametru konstruktora modelName
                Color = modelColor; //Varijabla Color je sada jednaka parametru konstruktora modelColor
                Year = modelYear; //Varijabla Year je sada jednaka parametru konstruktora modelYear
            }
        }
        
        public static void Constructors_2Example(string[] args)
        {
            Car myCar = new Car("BMW M5", "White", 2022); //kreiranje objekta myCar klase Car.
            Console.WriteLine(myCar.Model + " " + myCar.Color + " " + myCar.Year);
        }
    }
}