using System;

namespace cSharpFundamentals._26_Interface
{
    public interface IAnimalSound //kreiranje interface-a
    {
        void animalSound(); //metoda u IAnimalSound interface-u
    }

    public interface IDrinkable//kreiranje drugog interface-a
    {
        void animalDrinking(); //metoda u IDrinkable interface-u
    }

    class Bull : IAnimalSound, IDrinkable //kreiranje klase Bull koja implementira IAnimalSound i IDrinkable interface-e
    {
        public void animalSound()
        {
            Console.WriteLine("Bik govori Buuuu"); //ispis metode animalSound
        }
        
        public void animalDrinking()
        {
            Console.WriteLine("Bik pije vodu"); //ispis metode animalDrinking
        }
    }

    class Lion : IAnimalSound, IDrinkable //kreiranje klase Lion koja implementira IAnimalSound i IDrinkable interface-e
    {
        public void animalSound() 
        {
            Console.WriteLine("Lav govori: Roar");// ispis metode animalSound
        }
        
        public void animalDrinking() 
        {
            Console.WriteLine("Lav pije vodu");//ispis metode animalDrinking
        }
    }

    public class Program
    {
        public static void ProgramExample(string[] args)
        {
            Bull myBull = new Bull(); //kreiranje objekta klase Bull
            myBull.animalSound();
            myBull.animalDrinking();
            
            Lion myLion = new Lion(); //kreiranje objekta klase Lion
            myLion.animalSound();
            myLion.animalDrinking();
            
            //Kada koristimo vise interface-a i kod njigove implementacije moramo ih odvojiti zarezom jer ima vise.
        }
    }
}