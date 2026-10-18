using System;

namespace cSharpFundamentals._11_switch
{
    public class switchName {
        
        public static void SwitchExample(string[] args)
        {
            //Switch je efikasna alternativa za koricenje previse else if uvjeta.

            int ocjena = 5;
            switch (ocjena)
            {
                case 1:
                    Console.WriteLine(" tvoja ocjena je Nedovoljan" + ocjena);
                    break;
                case 2:
                    Console.WriteLine(" tvoja ocjena je dovoljan" + ocjena);
                    break;
                case 3:
                    Console.WriteLine(" tvoja ocjena je dobar" + ocjena);
                    break;
                case 4:
                    Console.WriteLine(" tvoja ocjena je vrlodobar" + ocjena);
                    break;
                case 5:
                    Console.WriteLine(" tvoja ocjena je odličan" + ocjena);
                    break;
                default: //defult sluzi ako korisnik unese vrijednost koja nije u opsegu switcha.
                    Console.WriteLine("tvoja ocjena nije ispravna");
                    break;
                
            }
        }
    }
}