using System;

namespace cSharpFundamentals._27_Enums
{

    enum Level //Kao da kreiramo klasu a svaki član enuma se odvaja zarezom
    {
        Junior, //index vrijednost 0
        Medior, //index vrijednost 1
        Senior, //index vrijednost 2
        TeamLead //index vrijednost 3
    }
    
    public class Enums
    {
        enum Predmeti//Takodjer Nabrajanja mozemo imati u klasi
        {
            Matematika, //vrijednost 0
            Fizika = 4, 
            Kemija,
            Tjelesno
        }
        
        public static void EnumsExample(string[] args)
        {
            //Enums su posebna vrsta klase koja u sebi sadrzi grupu konstati (Varijabli koje su ne promjenjive/read only varijable)
            //Enum je skracenica od enumerations sto znaci nabrajanje 
            
            
            Level myLevel = Level.Medior;
            Console.WriteLine(myLevel);

            Predmeti myPredmet = Predmeti.Tjelesno;
            Console.WriteLine(myPredmet);
            
            //Takodjer enumi mogu iamti svoje indexe tj brojeve prvi clan enuma je broj 0 za drugi 1 za treci 2 itd...
            //Kada zelimo ispisati index enuma moramo: kreirati int objekt i onda oznaciti clan enuma koji zelimo ispisati isto u int i onda ispisemo Console.WriteLine(myIndex);

            int myIndex = (int)Level.Senior;
            Console.WriteLine(myIndex);
            
            //takodjer mozemo mijenjati indexe u enumima i onda svaki sljedeci enum ima taj index + 1.
            //Posto smo stavili Fiziku da je index 4, onda ce za kemiju inex biti 5.
            int mojPredmet = (int)Predmeti.Kemija;
            Console.WriteLine(mojPredmet);
            
            //Enumi se cesto koriste u Switchevima: 

            Level myPosition = Level.Junior;
            switch (myPosition) //kreirali smo switch i implementirali objekt myPosition
            {
              case Level.Junior:
                  Console.WriteLine("Moja pozicija je Junior");
                  break;
              case Level.Medior:
                  Console.WriteLine("Moja pozicija je Medior");
                  break;
              case Level.Senior:
                  Console.WriteLine("Moja pozicija je Senior");
                  break;
              case Level.TeamLead:
                  Console.WriteLine("Moja pozicija je TeamLead");
                  break;
              //Zasto i kada koristimo enume?
              //Enume koristimo za vrijednosti koje su fiksne dani mjeseci.
              //Mozda nije najbolji primjer za predmete i pozicije u tvrtki ali moramo sam promjeniti varijable i same enume da primejri budu auteticni.
            }
        }
    }
}