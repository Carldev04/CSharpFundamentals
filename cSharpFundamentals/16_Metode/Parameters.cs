using System;

namespace cSharpFundamentals._16_Metode
{
    public class Parameters
    {

        static void MyMethod(string fname, int age)//(string fname) je parametar metode i "age" je parametar metode
                                                   //vise varijabli se odvajaju zarezom
        {
            Console.WriteLine(fname + " ima " + age);//Ovdje "fname" je argument metode MyMethod i ispisuje je ime za koje je pozvana metoda.
                                                     //"age" je argument metode MyMethod i ispisuje je godine za koje je pozvana metoda.
        }
        
        public static void ParametersExample (string[] args)
        {
            //Svaka metoda ima svoje parametre i argumente
            //Parametri su varijable koje se prosledjuju metodi
            //Argumenti su vrednosti koje se prosledjuju parametrima metode.
            
            MyMethod("Ivan", 22); //"Ivan" je argument parametra fname, a "22" je argument parametra godine
            MyMethod("Ana", 25); // "Ana" je argument parametra fname, a "25" je argument parametra godine
            MyMethod("Marko", 20); // "Marko" je argument parametra fname, a "20" je argument parametra godine
            
            //Pripajanjem vrijednostima parametara argumentima ako ih ima vise odvajamo zarezo. 
            //Mora biti jednak broj parametara i argumenta.
            
        }
    }
}