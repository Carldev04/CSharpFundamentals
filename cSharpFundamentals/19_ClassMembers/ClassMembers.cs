using System;

namespace cSharpFundamentals._19_ClassMembers
{
    public class ClassMembers
    {

        class Car //kreirali smo klasu Car
        {
            //Ovaj ne definiramo polja u klasi Car nego ostavljamo prazan i onda dopisujemo ono sto nam treba.
            public string model; //ovdje smo napravili polje model
            public string color; //ovdje smo napravili polje color
            public int year; //ovdje smo napravili polje year

            public void fullThrottle()
            {
                Console.WriteLine("Car is going as fast as it can!"); //Ovo ispisuje kada se pozove metoda fullThrottle
            }
            
        }
        
        public static void ClassMembersExample(string[] args)
        {
            Car Golf = new Car(); //Ovdje smo napravili objekt Golf koji je instanca klase Car
            Golf.model = "Golf"; //Ovdje smo dodali vrijednost polja model
            Golf.color = "White"; //ovje smo dodali vrijednost polja color 
            Golf.year = 2020; //Ovdje smo dodali vrijednost polja year

            Car Audi = new Car(); //Ovdje smo napravili objekt Audi koji je instanca klase Car
            Audi.model = "Audi"; //Ovdje smo dodali vrijednosti polja model.
            Audi.color = "Black"; //Ovdje smo dodali vrijednosti polja color.
            Audi.year = 2021; //Ovdje smo dodali vrijednosti polja year.

            Car myObj = new Car();
            myObj.fullThrottle();//Poziva metodu fullThrottle

            Console.WriteLine(Golf.model); //ispisuje model Golf-a
            Console.WriteLine(Audi.color); //ispisuje boju Audi-a
            Console.WriteLine(Golf.year); //ispisuje godiste golfa.
            
        }
    }
}