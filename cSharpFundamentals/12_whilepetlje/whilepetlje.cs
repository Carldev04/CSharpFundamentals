using System;

namespace cSharpFundamentals._12_whilepetlje
{
    public class whilepetlje
    {
        public static void WhilePetljaExample(string[] args)
        {
            //Petlje mogu izvršavati blok koda sve dok nije ispunjen određeni uvjet.
            //Petlje su korisne jer štede vrijeme, smanjuju broj pogrešaka i čine kod čitljivijim.
            
            //While petlja prolazi kroz blok koda sve dok je navedeni uvjet točan

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++; //Ova petlja će se ponavljati sve dok je i manje od 5
                
            //imamo i do/while petlju

            int b = 0;
            do
            {
                Console.WriteLine(b);
                i++;
            }
            while (i < 5);//do/while petlja ce se uvjek izvršiti bar jednom, cak i ako je uvjet ne istinit jer smo prvo
            //zapovjed da poveca vrijenost za jedan prije nego sto smo rekli ako je vrijednost manja od 5.
            
            
            //OBAVEZNO staviti ++ kod varijable jer ako to zaboravimo petlja ce se ponavljati zauvjek.
            
            }
        }
    }
}