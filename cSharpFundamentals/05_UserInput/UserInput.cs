using System;

namespace cSharpFundamentals._05_UserInput
{
    public class UserInput
    {
        public static void _UserInput_(string[] args)
        {
            //User input se sastoji od 3 koraka.
            
            //Prvi korak je ispisivanje poruke za unos imena.
            Console.WriteLine("Unesite ime:"); 
            
            //Drugi korak je kreiranje varijable za unos imena i zatim taj unos spremiti u metodu Console.ReadLine().
            string ime = Console.ReadLine();
            
            //treci korak ispisati varijablu ime u metodu Console.WriteLine().
            Console.WriteLine("Unijeli ste ime: " + ime);
            
            //Posto metoda Console.ReadLine vraca samo string ne mozemo dobiti povratnu informaciju drugog tipa podatka.
            //Kao sto je Int zato moramo imati dodatni korak Casting tj prebaciti string u drugi tip podatka kao sto je Int 

            Console.WriteLine("Unesi broj godina: ");
            
            //C# prvo cita kod koji je najdublje u zagradi a to je Console.ReadLine sprema unos godina kao string
            //Onda metodom Convert.ToInt32() prebacimo string u Int.
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Imate: " + age + "godina/godine");
        }
    }
}