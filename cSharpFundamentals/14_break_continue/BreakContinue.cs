using System;

namespace cSharpFundamentals._14_break_continue
{
    public class BreakContinue
    {
        public static void BreakContinueExample(string[] args)
        {
            //Sa naredbom break smo se vec susreli koristili smo je kao izalazak iz anredbe switch.
            //Break takodjer mozemo koristit i za izlazak i petlje.
            
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i); //ispisuje brojeve od 0 do 3 svejedno sto uvjet je zadovoljen da ide dalje ali break prekida petlju.
                
                //Continue prekida jednu interakciju unutar petlje i ako se uvjet ispunja da se petlja nastavi izvrsiti ce se do kraja.

                for (int b = 0; b < 10; b++)
                {
                    if (b == 4)
                    {
                        continue;
                    }
                    Console.WriteLine(b);//ispisuje brojeve od 0 do 9 ali ne ispisuje broj 4. Jer smo prekinuli jednu iteraciju unutar petlje.
                }
            }
        }
    }
}