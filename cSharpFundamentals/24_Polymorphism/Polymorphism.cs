using System;

namespace cSharpFundamentals._24_Polymorphism
{

    class Animal //klasa Animal
    {
        public virtual void animalSound() //metoda animalSound koja ispisuje: Zivotinja se glasa
        {
            Console.WriteLine("Zivotinja se glasa");
        }
    }

    class Pig : Animal //Napravili smo klasu svinja i stavili smo da nasljedi klasu Animal 
    {
        public override void animalSound()//ista metoda kao u klasi Animal ali ispisuje: Svinja govori: wee wee i stavili smo override na metodu animalSound
        {
            Console.WriteLine("Svinja govori: wee wee");
        }
    }

    class Dog : Animal//Napravili smo klasu pas i stavili smo da nasljedi klasu Animal 
    {
        public override void animalSound()//Ista metoda kao u klasi Animal ali ispisuje: Pas govori: vau vau i stavili smo override na metodu animalSound
        {
            Console.WriteLine("Pas govori: vau vau");
        }
    }
    
    public class Polymorphism
    {
        public static void PolymorphismExample(string[] args)
        {
            Animal myAnimal = new Animal();//Ovdje smo napravili objekt myAnimal ispisuje poruku tj metodu animalSound
            myAnimal.animalSound();

            Animal myPig = new Pig();//Ovdje smo napravili objekt myPig ispisuje poruku tj metodu animalSound
            myPig.animalSound();

            Animal myDog = new Dog();//Ovdje smo napravili objekt myDog ispisuje poruku tj metodu animalSound
            myDog.animalSound();
            
            //Ovdje nastaje problem zelimo da ispisemo da se svinja glasa wee wee i pas vau vau.
            //Pošto smo napravili metodu animalSound u klasi Animal a stavili smo da klasa svinja i pas nasljeduju Animal klasu.
            //Onda kompajler ispisuje poruku tj metodu animalSound iz klase Animal u sve 3 klase i ta je PROBLEM.
            
            //Taj problem možemo riješiti koristeći polimorfizam.
            //Polimorfizam se sastoji od Virtual i override metoda. 
            
            //Posto sve 3 klase imaju istu metodu animalSound koristeci Virtual i override metode rijesavamo taj problem tako sto.
            //iza public stavimo rijec virtual za metodu koja se nalazi u svim klasama koju zelimo polimorifrati
            //Onda trebamo nadjacati metodu animalSound u klasama svinja i pas.
            
            //Kompajler posto ima dvi razlicite poruke za istu metodu Animal on ispisuje metodu koja je parent.
            //dajemo doznanja ne zelim da se pokrene metoda Animal iz Animal klase nego da se pokrene metoda Animal iz klase svinja i pas.
            //To radimo tako sto stavimo override za metodu animalSound u klasama svinja i pas.
            
            //Takodjer ovaj cijeli kod mozemo napisati u 4 razlicita fajla tako sto.
            
            //1. fajl stavimo kod iz klase Animal i nazovemo ga AnimalSound.cs
            //2. fajl stavimo kod iz klase Pig i nazovemo ga Svinja.cs
            //3. fajl stavimo kod iz klase Animal i nazovemo ga Pas.cs
            //4. fajl stavimo kod iz klase Polymorphism i nazovemo ga GlasanjeZivotinja.cs    
            
            //Na ovaj nacin smo izbjegli spaggeti kod i kod kao sam projekt izgleda dosta profesionalnije.
        }
    }
}