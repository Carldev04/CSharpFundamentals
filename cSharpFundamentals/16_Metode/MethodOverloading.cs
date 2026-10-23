using System;

namespace cSharpFundamentals._16_Metode
{
    public class MethodOverloading
    {
        
        static int PlusMethod(int x, int y)//Kreiramo metodu koja vraca zbir dva broja u integeru.
        {
            return x + y;//Ovo metoda izvrsava kad je pozovemo.
        }

        static double PlusMethod(double x, double y)//Kreiramo metodu koja vraca zbir dva broja u doublu.
        {
            return x + y;//Ovo metoda izvrsava kad je pozovemo.
        }
        
        public static void MethodOverloadingExample(string[] args) 
        {
            int result = PlusMethod(10, 5);//Dodajemo vrijednost parametru 
            double result2 = PlusMethod(10.87, 5.54);//Dodajemo vrijednost parametru
            
            Console.WriteLine("Int je: " + result);// ispisuje 15
            Console.WriteLine("Double je: " + result2); //ispisuje 15.5
            
            //Jedino sto moramo zapamtit kada je dozvoljeno koristiti method overloading je da imamo isti naziv metode ali razliciti tipovi parametara.
            //Da su obje metode koristile parametar int nebi radilo. 
        }
    }
}