using System;
using System.IO; //
namespace cSharpFundamentals._28_Files

{
    public class Files
    {
        public static void FilesExample(string[] args)
        {
            string markovNotes = "Ja sam Marko.\nImam 22 godine.\nStudiram na Fakultetu Elektrotehnike i Računarstva.\n";
            File.WriteAllText("Marko.txt", markovNotes);//Kreorali smo MarkovNotes i dodali smo njegovu biografiju.
            
            string anteNotes = "Ja sam Ante.\nImam 21 godine.\nStudiram na Građevinskom fakultetu.\n";
            File.WriteAllText("Ante.txt", anteNotes);//Kreorali smo AnteNotes i dodali smo njegovu biografiju.
            
            string writeText = "Pozdrav iz Ridera opet"; //Posto sam izbrisao kod sa File.txt opet sam ga dodao. 
            File.WriteAllText("File.txt", writeText);  
            
            string readText = File.ReadAllText("Ante.txt");
            Console.WriteLine(readText); //Ispisuje Ante.txt u konzolu.
            
            string readText2 = File.ReadAllText("Marko.txt");
            Console.WriteLine(readText2); //Ispisuje Marko.txt u konzolu.

            string readText3 = File.ReadAllText("File.txt");
            Console.WriteLine(readText3); //Ispisuje File.txt u konzolu.
            
            //Zadnji zadatak 7. radimo metodu (Replace)
            //kreirali smo 3 varijable sourceFileName, destinationFileName i destinationFileName2 i njih smo koristili kao parametre u metodi Replace()
            string sourceFileName = "Ante.txt";
            string destinationFileName = "Marko.txt";
            string destinationFileName2 = "voce.txt";
            
            
            
            //Kada smo kreirali tri datoteke sada cemo malo manipulirati sa System.IO metodama kao sto su: AppendAllText(), Delete(), Replace()
            
            //Koristeći metodu AppendAllText() dodaj na postojeću datoteku Ante.txt da: "Marko voli životinje\n"

            string dodanMarkovNotes = "Marko voli životinje\n";
            File.AppendAllText("Marko.txt", dodanMarkovNotes); //Dodali smo text u već postojeći fajl. 
            
            //koristeći Copy() kopirati datoteku File.txt u kopija_File.txt
            File.Copy("File.txt", "kopija_File.txt", true);
            
            //Provjeriti da li postoji file pod nazivom kopija_File.txt postoji i neka ispise poruku "Datoteka kopija_File.txt postoji."
            if (File.Exists("kopija_File.txt"))
            {
                Console.WriteLine("Datoteka kopija_File.txt postoji.");
            }
            else
            {
                Console.WriteLine("Datoteka kopija_File.txt ne postoji.");
            }
            
            //koristeci metodu Delete() izbrisati datoeteku File.txt
            File.Delete("File.txt");
            
            //Koristeci metodu File.Exists() provjeriti jel zaista datoteka File.txt izbrisana.
            if (File.Exists("File.txt"))
            {
                Console.WriteLine("Datoteka File.txt postoji.");//obican if statement
            }
            else
            {
                Console.WriteLine("Datoteka File.txt ne postoji.");
            } 
            
            //Kreirati novu praznu txt datoteku pod imenom voce.txt
            File.Create("voce.txt").Close();
            //kreirana prazna datoteka voce.txt i zatvorili je jer da je nismo zatvorili. Kod ispod bi pucao
            
            //koristeci metodu Replace() zamjenuti markovNotes sa anteNotes ali da Marka spremi u voce.txt
            File.Replace(sourceFileName, destinationFileName, destinationFileName2);
            Console.WriteLine("Datoteka Marko.txt je zamijenjena sa Ante.txt i spremljena kao voce.txt.");
            //Posto se datoteka Marko.txt je zamijenjena sa Ante.txt i spremljena kao voce.txt, datoteka Ante.txt je izbrisana.
            
            //Ovaj kod je mogao biti napisan u dva fajla kao u pravom OOP duhu.
            //Prvi bi fajl sadrzavao sve metode koje smo koristili za kreiranje datoteka i zadnje 3 metode koje smo koristili za parametre u metodi Replace()
            //Drugi fajl bi bio jedan veliki komentar sa zadacima i onda bi samo pisali File.(pa sve metode koje smo vjezbali.)
        }
    }
}