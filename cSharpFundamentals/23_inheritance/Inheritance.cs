using System;

namespace cSharpFundamentals._23_inheritance
{
    
    //Nasljedjivanje ili Inheritance - postupak gdje child klasa nasljeduje metode i svojstva od parent klase.
    //To radimo tako što child klasa koristi : operator i onda oznacimo parent klasu.
    //Inheritance se koristi da nebi kod jedne klase opet prepisivali u novoj klasi samo nova klasa nasljedi staru i nastavlja se.
    //TIP: Ako zelimo da se neka klasa nikad ne naljedimo onda stavimo sealed rijec sealed ispred klase.
    

    public class Vehicle// Kreirali smo klasu Vehicle 
    //Da smo htjeli da se ova klasa nikad ne nasljedi to radimo ovako
    //sealed class Vehicle
    {
        public string brand = "Ford";//Napravili smo joj polje/varijablu pod imenom brand

        public void honk()//kreirali smo metodu honk
        {
            Console.WriteLine("Tuuu Tuuu");
        }
    }
    class Car : Vehicle// Ovjde smo napravili klasu Car i ona nasljeđuje Vehicle
    {
        public string modelName = "Mustang";//Unutar klase Car napravili smo polje/varijablu pod imenom modelName.
    }
    
    public class Inheritance//public klasa 
    {
        public static void InheritanceExample(string[] args)
        {
            Car myCar = new Car();//kreirali novi objekt klase Car
            
            myCar.honk();//pozvali smo metodu honk koju smo nasljedili od Vehicle klase.
            
            Console.WriteLine(myCar.brand + " " + myCar.modelName);//ispisali smo vrijednosti varijabli brand i modelName.
        }
    }
}