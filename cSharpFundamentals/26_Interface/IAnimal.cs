using System;

namespace cSharpFundamentals._26_Interface
{ 
    public interface IAnimal //Kreirali smo interface IAnimal
    {
        //Jos jedan nacin kako doci do abstrakcije je koriscenjem interface-a
        //Interface - kao abtraktna klasa koja moze da sadrzi: abstraktne metode i property-je sa praznim tjelom 
        //Dobra praksa da public interface bude prvo slovo I da se zapamti da je to interface
        //Po defultu clanovi interfacea su abstraktni i public
        //Interface mogu sadrzavati property i metode ali ne i polja
        //Interface ne moze sadrzavati konstruktore time se ne moze kreirati objekat
        //Ako primjetimo nismo overridali metodu animalSound jer se u interfaceu jer ne zauzima prostor i onda samim tim nemamo sto overridati.
        //Unutar njega napravili smo abstraktnu metodu animalSound.
        //Interface koristimo da bi postigli sigutnost: sakrivamo odredjene detalje a prikazujemo samo vazne detalje interfeca
         void animalSound();
    }

    class Bird : IAnimal//Nova klasa Bird koja implementira IAnimal interface
    {
        public void animalSound()//Unutar klase napravili smo metodu animalSound
        {
            Console.WriteLine("Tweet tweet"); //ispis
        }
    }

    class Cow : IAnimal //Nova klasa Cow koja implementira IAnimal interface
    {
        public void animalSound() //Unutar klase napravili smo metodu animalSound
        {
            Console.WriteLine("Muu Muu");//ispis
        }
    }
    
    class GlasanjeZivotinja //Nova klasa GlasanjeZivotinja
    {
        public static void GlasanjeZivotinjaExample(string[] args)
        {
            Bird myBird = new Bird(); //kreirali smo objekat myBird koji pripada klasi Bird
            Cow myCow = new Cow(); //kreirali smo objekat myCow koji pripada klasi Cow
            
            myBird.animalSound();
            myCow.animalSound();
            
            //U C# klasa moze nasljediti samo jednu klasu public ili abstract ali zato mozemo implementirati koliko zelimo interfacea ali ih moramo odvojiti zarezom.
        }
    }
}