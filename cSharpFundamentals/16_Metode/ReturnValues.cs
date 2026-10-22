using System;

namespace cSharpFundamentals._16_Metode
{
    public class ReturnValues
    {
        
        static int MyMethod (int Zbrojnik, int Zbrojnik2)//kada od metode trazimo return vrijednost ne moze biti vise void nego se stavlja int double i itd.
                                          //Return moramo napisati u samoj metodi jer vise nije void.  
        {
            return Zbrojnik + Zbrojnik2;//Ovdje se ispisuje sto ce Metoda raditi,
        }
        public static void ReturnValuesExample (string[] args)
        {
            int zbroj = MyMethod(10, 5); //Ovdje smo napravili varijablu zbroj kojoj smo dodijelili vrijednost metode MyMethod koja ima parametre 10 i 5
            Console.WriteLine(zbroj);
            
            Console.WriteLine(MyMethod(10, 5)); // dodjeluje vrijednost 10 parametru Zbrojnik i vrijednost 5 parametru Zbrojnik2 i ispisuje 15
            
            //Oba nacina su ispravna ali prvi nacin je malo prakticniji.
            
        }
    }
}