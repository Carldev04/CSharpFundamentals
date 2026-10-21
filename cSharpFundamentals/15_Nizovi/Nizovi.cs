using System;

namespace cSharpFundamentals._15_Nizovi
{
    public class Nizovi
    {
        public static void NizoviExample(string[] args)
        {
            //Array se koriste za pohranu više vrijednosti u jednoj varijabli, umjesto deklariranja zasebnih varijabli za svaku vrijednost.
            
            string[] cars = {"Volkswagen", "BMW", "Audi", "Mazda"}; //array sa stringovima.
            int[] myNumbers = {10, 20, 30, 40, 50};
            
            //Da bi pristupili pojedinom elementu u nizu trebamo ga indexirati. Da bi ispisali vr recimo cars trebamo indexirati cars[0] i onda ga ispisati.
            Console.WriteLine(cars[0]); //ispisuje Volkswagen jer prvi element u nizu pocinje sa indexom 0 
            Console.WriteLine(myNumbers[1]); //ispisuje 20 jer je drugi element u nizu sa indexom 1
            
            //Da bi smo promjenuli neki element u nizu to radimo na sljedeci način.
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            
            //Ako nam brzo treba da znamo koliko neki niz ima elemeanata u sebi to radimo Length svojstvom.
            Console.WriteLine(cars.Length); //ispisuje 4 jer je cars niz sa 4 elementa.
            
            //Imamo više načina za kreiranje nizova.
            
            //kreiranje niza od 4 elementa a vrijednosti dodajemo kasnije 
            string[] pets = new string[4];
            
            //kreiranje niza od 4 elementa a vrijednosti odmah.
            string[] colors = new string[4] {"Red", "Green", "Blue", "Yellow"};
            
            //Kreiramo niz od 4 elementa a ne navedemo koliko će niz imati elemenata
            string[] techProducts = new string[] {"computer", "phone", "tablet", "printer"};
            
            //Kreiramo niz od 4 elementa a riječi new string[] i bez specifičnog broja elemenata.
            string[] fruits = {"Apple", "Banana", "Orange", "blueberry"};
            
            //Koju god način kreiranja nizova to nije bitno ali zadnji način je najlakši i napraviti i čitati kasnije.
            
            colors = new string[] {"Black", "White"};
            
            //Ovdje se stari niz colors izbrise i kreira novi niz koji ima dva elementa Black i White.
        }
    }
}