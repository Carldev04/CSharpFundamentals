using System;

namespace cSharpFundamentals._15_Nizovi
{
    public class MultidimensionalArrays
    {
        public static void MultidimensionalArraysExample (string[] args)
        {
            //Obični niz sa kojima smo radili su 1D nizovi jer smo pravili jedan niz.
            //Dok recimo 2D niz kao tablica ima redove i stupce.
            //Sintaksa za stvaranje 2d niza koristi zarez unutar uglastih zagrada kako bi oznacilo broj dimenzija.

            int[,] numbers = { { 1, 4, 2 }, {3, 6, 8} };//prvi red 1,4 i 2 drugi red 3,6 i 8.
            
            //kod ispisivanje elemenata niza u 1D nizu koristilimo smo indexe ali u 2D nizu korisimo 2 indexa jedan za red i jedan za stupac.
            
            Console.WriteLine(numbers[0, 2]); //Prvi index upituje u kojem redu se uzima broj. Drugi index uzima element u tom redu.
            //Ovdje ce ispisati broj 2 jer je to treci element u prvom redu.
            
            //takodjer mozemo mijenjati elemente nekog niza 
            numbers[0, 0] = 4;//Uzima prvi element u prvom redu i mijenja ga na 4. //to znaci da ce se broj 1 pretvoriti u 4.
            
            //Takodjer mozemo koristit i petlje u 2D nizu.
            foreach (int number in numbers)
            {
                Console.WriteLine(number);//prvo ispisuje po redu prvi red znači 4, 4 2 i onda prelazi na drugi red i ispisuje 3,6 i 8.
            }
            
            //Mozemo takodjer koristit for petlju u 2d nizu.
            //Moramo biti pazljivi da koristimo GetLength umjesto Length jer u ovom nizu imamo i redtke i stupce.

            for (int i = 0; i < numbers.GetLength(0); i++)//prolazi kroz redove, vrsi se dva puta jer ima dva reda
            {
                for (int j = 0; j < numbers.GetLength(1); j++)//prolazi kroz stupce, jer u svakom redu ima 3 stupca.
                {
                    Console.WriteLine(numbers[i, j]);//prvo izvrsava 0,0 0,1 i 0,2 pa prelazi u novi red 1,0 pa 1,1 pa 1,2
                }
            }
        }
    }
}