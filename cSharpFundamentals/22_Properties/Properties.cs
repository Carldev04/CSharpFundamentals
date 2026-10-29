using System;

namespace cSharpFundamentals._22_Properties
{

    class Person
    {
        private string name;// privatno polje name
        public string Name// ovdje deklariramo properti i obavezno varijablu/polje staviti velikim slovom.
        {
            //// za pravljenje propertija koristimo sljedeci format
            get {return name;}//get {return varijabla;}
            set {name = value;}//set {varijabla = value;}
        }
    }
    
    public class Properties
    {
        public static void PropertiesExample(string[] args)
        {
            //Da bi koristili properties moramo razumit sto znaci enkapsulacija 
            //Enkapsulacija - zastita osjetljivih podataka od vanjskih utjecaja uz istovremeno pružanje mogućnosti pristupa njima dok su ti podaci u private modifikatoru.
            
            //Da bi smo to postigli moramo polja ili varijable da stavimo kao private.
            //Deklariramo public get i set metodu unutar properties-a tako da im mozemo pristupiti izvan klase i promjenuti njihove vrijednosti.
            
            //U modifikatorima smo ucili da private modifikatoru ne mozemo pristupiti izvan klase. Nekad u buducnosti cemo morati pristupiti tim izvan klase.
            //Ali svejedno podaci unutar privatea zbog osjetljivosti moraju ostat private i onda moramo koristiti properties (get i set) da bi oba uvijeta bili zadovoljena.
            
            Person obj = new Person();
            obj.Name = "Marko";//pozivamo objekt koji smo napravili nazivObjekta.nazivPropertija = "Marko";
            
            Console.WriteLine(obj.Name);//ispisujemo objekt.
        }
    }
}