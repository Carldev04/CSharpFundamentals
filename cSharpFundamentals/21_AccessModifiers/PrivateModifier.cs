using System;

namespace cSharpFundamentals._21_AccessModifiers
{
    class Car //kreiranje klase Car
    {
        public string model = "BMW"; //kreirali polje model
        //Jos jedan trik ako nebi stavili nista public ni private string model = "BMW"; taj model bi bio private
    }
    
    public class PrivateModifier
    {
        public static void PrivateModifierExample(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine(myCar.model);
        }
    }
    
    /*
    using System;
    
    namespace cSharpFundamentals._21_AccessModifiers
    {
    
    class Car//kreirali smo klasu Car
    {
        private string model = "Golf"; //kreirali polje model
    }

    public class PrivateModifier
    {
       
        public static void PrivateModifierExample(string[] args)
        {
            Car myCar = new Car();//kreirali smo objekt myCar.
            Console.WriteLine(myCar.model);//ispisuje vrijednost polja model.
            //                                                      //
            // VAŽNA NAPOMENA KOD NE RADI JER JE POLJE MODEL PRIVATE//
            //                                                      // 
        } 
    }
    }
    */
}