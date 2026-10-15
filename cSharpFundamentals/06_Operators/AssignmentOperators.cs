namespace cSharpFundamentals._06_Operators
{
    public class AssignmentOperators
    {
        public static void _AssignmentOperators_(string[] args)
        {
            //Operatori pridruživanja koriste se za pridruživanje neke vrijednosti varijablama.
            //Primjer:

            int x = 10;
            x += 5; //Varijabli x se dodaje vrijednost 5
            
            /*
            Uzmimo vrijednost 10 i operator broj 3 	
            += uzima broj 10 i pridruzuje 3
            -= uzima broj 10 i oduzima za 3	
            *= uzima broj 10 i mnozi ga za 3 		
            /= uzima broj 10 i dijeli ga za 3		
            %= uzima broj 10 i modularno ga dijeli i dobijemo 1	
            &= uzimamo broj 10 i pretvara ga u binarni oblik, zatim pretvorimo broj 3 u binarni oblik stavimo oba binarna 
            broja jedan ispod drugog i usporedjujemo svaki bit jedan ispod drugog ako oba imaju jedan rezultat pisemo 1 i svakom drugom slucaju pisemo 0
        	
            |= Pravilo: Rezultat je 1 ako je barem jedan od bitova 1.
            ^= ravilo: Rezultat je 1 samo ako su bitovi različiti (jedan je 1, a drugi 0). Ako su isti (oba nule)		
            >>= Pravilo: Pomjera sve bitove udesno za 3 mjesta. Zamisli da guraš broj 1010 udesno, a sve što a sve što "ispadne" sa desne strane se briše.		
            <<= Pravilo: Pomjera bitove ulijevo za 3 mjesta dodajući nule na kraj. 1010 postaje 1010000 i to je 80.
             */
        }
    }
}