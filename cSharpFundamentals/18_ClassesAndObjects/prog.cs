namespace cSharpFundamentals._18_ClassesAndObjects
{
    public class Car// kreiralo klasu 
    {
        public string color = "white"; //varijabla ili polje white
    }
    
    public class prog
    {
        public static void progExample(string[] args)
        {
            
        }
        //Koristimo vise fajlova sada cemo u jednoj fajlu kreirati klasu Car a u drugoj fajlu kreirati objekt i ispisati njegovu boju.
        //Zasto ovo radimo? 
        
        //Jer kada u buducnosti budemo zeljeli raditi sa vise clasa objekata da sve drzimo u istom fajlu taj kod bi postao teze citljiv.
        //I postao bi spaggeti kod zato razvajamo isti kod u vise fajlova tako da bude citljiviji.
        
    }
}