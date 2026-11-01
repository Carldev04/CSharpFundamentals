using System;

namespace cSharpFundamentals._29_Exceptions
{
    public class Exceptions
    {
        public static void ExceptionsExample(string[] args)
        {
            //Iznimke se mogu dogoditi kada se desi neka pogreška ili neispravan unos. Od strane developera ili korisnika.
            //Zato su tu try catch i finally blokovi.
            
            //Naredba Try: Oznacava blok koda na kojem ce se testirati na greske tijekom izvrsavanja programa.
            //Naredba Catch: Oznacava blok koda koji ce se izvrsiti ukoliko se dogodi greska u bloku try.
            
            //Try i Catch blokovi koriste se u paru.

            try
            {
                int[] myArray = { 1, 2, 3, 4, 5 }; //kreirali smo niz od 5 elemenata
                Console.WriteLine(myArray[10]); //Zelimo ispisati element na poziciji 10, ali niz ima samo 5 elemenata, pa ce se dogoditi greska.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            //Takodjer mozemo ispisati i vlastiu poruku
            //Imamo i finally blok koji ce se izvrsiti u svakom slucaju, bez obzira na to da li je bila greska ili ne.
            try
            {
                int[] myArray = { 1, 2, 3, 4, 5 }; //kreirali smo niz od 5 elemenata
                Console.WriteLine(
                    myArray
                        [10]); //Zelimo ispisati element na poziciji 10, ali niz ima samo 5 elemenata, pa ce se dogoditi greska ili kada koriskik takodjer upise broj koji ide u minus kao -5.
            }
            catch (Exception e)
            {
                Console.WriteLine("Niz ima samo 5 elemenata");
            }
            finally
            {
                Console.WriteLine("Hvala na razumijevanju");
            }
        }
        
        //Imamo i throw statement koji nam sluzi da napravimo custom gresku. 
        //koristeci throw sa exception klasom + nasom porukom pravimo custom gresku.
        //Imamo raznih tipova exception klasa koje mozemo koristiti za custom greske.
        
        //ArgumentNullException //Koristimo je kada korisnik za unos ne unese neki argument npr pitamo korisnika za ime.
        //ArgumentOutOfRangeException //Kada imamo neki niz od 10 brojeva ali korisnik unese broj koji je van opsega niza.
        //DivideByZeroException //Ova gresku upotrebljavamo kada korisnik zeli broj podjeliti sa 0
        //FileNotFoundException //Koristimo za System.IO kada trazeni fajl ne postoji.
        //TimeoutException //Koristimo za System.Threading kada trazeni proces ne zavrsi u odredjenom vremenu.
        
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Nije dozvoljeno pristupiti sa manjim od 18 godina");
            }
            else
            {
                Console.WriteLine("Pristup je dozvoljen");
            }
        }
            public static void checkAgeExample(string[] args)
            {
            checkAge(15);
            }
            
            //Takodjer mogao sam za svaki exception napraviti jedan primjer i svaki spremiti u različiti fajl
            //Ali mi se neda :D zelim da ounacim ovaj REPO kao gotov.
            //Kad se sjetim svaki dan cu dodavat jedan fajl sa primjerom za svaki exception.
    }
}