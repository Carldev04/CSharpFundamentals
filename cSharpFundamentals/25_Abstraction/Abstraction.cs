using System;

namespace cSharpFundamentals._25_Abstraction
{

    abstract class Animal //Kreoramo abstraktnu klasu
    {
        public abstract void AnimalSound();//Unutar apstraktne klase kreiramo apstraktnu metodu

        public void Sleep()//Unutar apstraktne klase kreiramo metodu koja ispisuje poruku zivotinje spavaju
        {
            Console.WriteLine("Zivotinje spavaju");
        }
    }

    class Pig : Animal //Kreiramo klasu svinja koja nasljeđuje apstraktnu klasu Animal
    {
        public override void AnimalSound() ////Pravimo istu metodu u nasljedjenoj klasi Pig i nju overrajdamo
        {
            Console.WriteLine("svinja govori: wee wee");//Sto Overrajdana metoda u nasljedjenoj klasi Pig radi ispisuje poruku.
        }
    }

    class Cat : Animal //Kreiramo klasu mačka koja nasljeđuje apstraktnu klasu Animal
    {
        public override void AnimalSound() //Pravimo istu metodu u nasljedjenoj klasi Cat i nju overrajdamo 
        {
            Console.WriteLine("mačka govori: meow meow");
        }
    }
    
    public class Abstraction
    {
        public static void AbstractionExample(string[] args)
        {
            Pig myPig = new Pig();
            Cat myCat = new Cat();
            
            
            myPig.AnimalSound();
            myCat.AnimalSound();
            myPig.Sleep();
            myCat.Sleep();
            
            //Abstraktna klasa je klasa u kojoj ne možemo kreirati objekte da bi pristupili objektima moramo napraviti novu klasu i ona mora nasljediti apstraktnu klasu.
            //Preko nasljedjenje klase mozemo koristit iste metode i svojstva koje su definirana u apstraktnoj klasi i preko nje mozemo napraviti nove objekte a metode overridati.
            //Tako dodjemo da svinja govori wee wee a mačka meow meow.
            //U Abstraktnim klasama postoje abstraktne metode koje nemaju tijelo tj nemaju {} a abstraktna klasa moze imati asbtraktne metode i metode sa {}.
            
            //Takodjer ovaj kod mozemo napisati isto u 4 razlicita fajla kao u prosloj lekciji polimorfizma tako sto napravimo 4 sljedeca fajla:
            //1. Animal.cs kopiramo kod iz abstraktne klase linja 6. 
            //2. Pig.cs kopiramo kod iz klase Pig linija 16.
            //3. Cat.cs kopiramo kod iz klase Cat linija 24.
            //4. GlasanjeZivotinja.cs kopiramo kod iz klase Abstraction linija 32 
            
        }
    }
}