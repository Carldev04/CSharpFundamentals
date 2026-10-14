namespace cSharpFundamentals
{
    public class Constants
    {
        public static void _constants_(string[] args)
        {
          //Ako zelimo da neka vrijendost u varijabli ostane ista i da ne moze promjenuti moramo deklarirati varijablu kao const
          //Kada deklariramo const varijablu ta varijabla mora imati neku vrijednost ne moze biti prazno
          
          /*
           
           const int myNum = 15; prva greska 
          myNum = 10;
          
          */
          
          /*
          const int myNum; druga greska 
          */
          
          const int myNum = 15; //Ovo je pravilan nacin deklariranja const varijable
          
          
          
        }
    }
}