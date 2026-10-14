using System;

namespace cSharpFundamentals._03_Data_Types
{
    public class DataTypes
    {
        public static void _DataTypes_(string[] args)
        {
            //Kao sto smo ranije objasnili o varijablama u c# mora biti nekog podatkovnog tipa.
            
            //Integer (cijeli broj) u memoriji zauzima 4 bajta, sprema brojeve od -2.147.483.648 do 2.147.483.647
            //Long (cijeli broj) u memoriji zauzima 8 bajta, sprema brojeve od -9.223.372.036.854.775.808 do 9.223.372.036.854.775.807.
            //Double (decimalni broj) u memoriji zauzima 8 bajta, Pohranjuje brojeve s decimalnim dijelom. Dovoljno za pohranu 15 decimalnih znamenki.
            //Float (decimalni broj) u memoriji zauzima 4 bajta, Pohranjuje brojeve s decimalnim dijelom. Dovoljno za pohranu 7 decimalnih znamenki.
            //char (sprema jedan znak) u memoriji zauzima 2 bajta, sprema jedan znak/slovo koji je okruzen navodnicima.
            //Boolean (logički tip moze biti true/false) u memoriji zauzima 1 bajt.
            //String (sprema niz znakova i slova) u memoriji zauzima 2 bajta za svaki znak.
            
            //Sto se tiče brojevnih tipova podataka imamo dva a to su: cijeli i decimalni.
            
            //Cjeli brojevi: Oni spremaju negativne i pozitivne cijele brojeve imamo ih 2 int (integer) i long.
            
            //int sprema brojeve od -2.147.483.648 do 2.147.483.647 (4 bajta)
            
            int myNum = 100000;
            Console.WriteLine(myNum);
            
            //long sprema brojeve od -9.223.372.036.854.775.808 do 9.223.372.036.854.775.807 (8 bajta) koristimo kada trebamo spremiti brojeve koje ne moze spremiti integer i moramo staviti slovo L na krajuvrijednosti.

            long myLong = 15000000000L;
            Console.WriteLine(myLong);
            
            //Tipovi podataka s pomičnim zarezom, koristimj decimalne brojeve imamo dvije vrste: float i double.
            //Imajte na umu da vrijednost treba završiti slovom „F” za `float` i „D” za `double`:

            float myFloat = 5.75F;
            Console.WriteLine(myFloat);

            double myDouble = 19.90D;
            Console.WriteLine(myDouble);
            
            //Kada koristimo double a kada float? 
            
            //float sprema 7 decimala iza točke
            //double sprema 15 decimala iza točke.
            
            //Znanstveni brojevi. 
            
            //Broj s pomičnim zarezom može biti i broj u znanstvenom zapisu sa slovom „e” koje označava potenciju broja 10

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            
            //Booleans
            //Logički tip podataka deklarira se ključnom riječi bool i može poprimiti samo vrijednosti true/false:

            bool isCSharpFun = true; 
            bool isFishTastyGood = false;
            Console.WriteLine(isCSharpFun); //rijesenje je true 
            Console.WriteLine(isFishTastyGood); //rijesenje je false
            
            //Characters
            
            //Podatkovni tip `char` koristi se za pohranu jednog znaka. Znak mora biti omeđen jednostrukim navodnicima, kao što su 'A' ili 'a':

            char myGrade = 'A';
            Console.WriteLine(myGrade);
            
            //Strings
            
            //Tip podataka string koristi se za pohranu niza znakova (teksta). Vrijednosti tipa string moraju biti omeđene dvostrukim navodnicima:
            
            string greeting = "Hello World";
            Console.WriteLine(greeting);
        }
    }
}