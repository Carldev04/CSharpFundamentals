using System;
using System.Linq;

namespace cSharpFundamentals._15_Nizovi
{
    public class SortArrays
    {
        public static void SortArrays_Example(string[] args)
        {
            //Postoji mnogo metoda za nizove na primjer: sort koji razvrstava nizove abecednim redom ili u rastucem redosljedu.
            
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            Array.Sort(cars);//sort metoda
            foreach (string car in cars)
            {
                Console.WriteLine(car);//ispisuje marke automobila po abecednom redoslijedu
            }

            int[] numbers = { 5, 10, 3, 87, 12, 2};
            Array.Sort(numbers);//sort metoda
            foreach (int number in numbers)
            {
               Console.WriteLine(number);//Ispisuje brojeve od najmanjeg do najveceg
            }
            
            //ostale korisne metode kao Min, Max and Sum mogu se pronaci u System.Linq bibloteci
            
            Console.WriteLine(numbers.Max());//ispisuje najveci broj u nizu
            Console.WriteLine(numbers.Min());//ispisuje najmanji broj u nizu
            Console.WriteLine(numbers.Sum());//ispisuje sumu brojeva u nizu
        }
    }
}