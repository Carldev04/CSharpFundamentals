using System;

namespace cSharpFundamentals
{
    public class Variables
    {
        public static void Main2(string[] args)
        {
            /*
                Imamo sljedeci tipove podataka:
                int sprema cijeliBroj = 100;
                double sprema decimalniBroj = 100.5;
                char sprema jedan caracter kao "a", "c"... 
                string sprema tekst = "Hello World!"
                bool sprema vrijednost koja moze imati dva stanja true ili false.
            */

            string name = "John";
            Console.WriteLine(name);

            int myNum;
            myNum = 15;
            Console.WriteLine(myNum);

            //Ovje ce ispisati 23 jer age C# ispisuje uvijek najnoviju vrijednost.
            int age = 22;
            age = 23;
            Console.WriteLine(age);
            
            //drugi tipovi varijabli:
            int number = 10;
            double myDoubleNumber = 10.99;
            char myLetter = 'D'; //C# se mora kod char varijable koristit '' a ne ""
            bool myBool = true; 
            string myText = "Hello World!"; 

            
        }
    }
}