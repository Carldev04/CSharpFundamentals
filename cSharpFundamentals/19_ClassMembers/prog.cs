using System;

namespace cSharpFundamentals._19_ClassMembers
{
    public class Car
    {
        public string model; // definirali smo polje model u klasi Car
        public string color; // definirali smo polje boja u klasi Car
        public int year; // definirali smo polje godine u klasi Car
        public void fullThrottle() // definirali smo metodu fullThrottle u klasi Car
        {
            Console.WriteLine("Car is going on max speed!"); //Ovu poruku ispisuje kada se metoda pokrene.
        }
    }
}
