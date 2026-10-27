using System;

namespace cSharpFundamentals._19_ClassMembers
{
    public class prog2
    {
        public static void prog2Example(string[] args)
        {
            Car Golf = new Car(); //Napravili smo novi objekt Golf koji je nastao iz clase Car
            Golf.model = "Passat B9"; //dodali smo vrijednost polju modela za objekt golf
            Golf.color = "White"; //dodali smo vrijednost polju boja za objekt golf
            Golf.year = 2026; //dodali smo vrijednost polju godine za objekt golf
            
            Car Audi = new Car(); //Napravili smo novi objekt Audi koji je nastao iz clase Car
            Audi.model = "A7"; //dodali smo vrijednost polju modela za objekt audi
            Audi.color = "Grey"; //dodali smo vrijednost polju boja za objekt audi
            Audi.year = 2026; //dodali smo vrijednost polju godine za objekt audi
            
            Console.WriteLine(Golf.model); //ispisuje model Golf-a
            Console.WriteLine(Audi.model); //ispisuje model Audi-a
            Console.WriteLine(Golf.color); //ispisuje boju Golf-a
            Console.WriteLine(Audi.year); //ispisuje godinu proizvodnje Audi-a
            
            Golf.fullThrottle(); //pozivamo fullThrottle metodu za objekte Golf tako sto pozovemo nov objeket.nazivmetode();
            Audi.fullThrottle(); //pozivamo fullThrottle metodu za objekte Audi tako sto pozovemo nov objeket.nazivmetode();
        }
    }
}