using System;

namespace cSharpFundamentals._20_Constructors
{
    public class Constructors_1
    {

        public class Car //kreiranje klase
        {
            public string model; //kreiranje varijable/polja

            public Car() //kreirali smo konstruktor mora imati isto ime kao i klasa
            {
                model = "M5";//Ovo zapravo konstruktor ispisuje varijablu model
            }
        }
        
        public static void ConstructorsExample(string[] args)
        {
            Car BMW = new Car();//kreiranje objekta NEW u liniji 20 zapravo poziva konstruktor koji je na liniji 12 a ispisuje model = M5 koji je na liniji 14
            Console.WriteLine(BMW.model); //ispisivanje varijable
            
            //3 vazna pravila za konstruktore
            //1. Konstruktor mora imati isto ime kao i klasa
            //2. Konstruktor ne moze imati return tip npr: void, int, double... mora biti u formatu "public 'ImeKlase()'
            //3. Uvjek se poziva nakon kreiranja objekta.
            //4. Konstruktor se poziva automatski ali ima svoj ukidač new u liniji 20 kada kreiramo objekt u ovom primjeru.
        }
    }
}