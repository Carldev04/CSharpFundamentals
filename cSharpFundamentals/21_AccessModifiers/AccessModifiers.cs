namespace cSharpFundamentals._21_AccessModifiers
{
    public class AccessModifiers
    {
        public static void AccessModifiersExample(string[] args)
        {
            //Riječ public u psvm je modifikator i kao takvom bilo koja druga klasa ili bilo koja druga datoteka u projektu može pristupiti koji je napisan u publiku.
            //Imamo vise Access Modifiers-a: Public, private, protected, internal i dvije kombinacije njih: protected internal i private protected.
            
            //private - modifikator koji daje dozvolu da se moze pristupiti kodu samo ta klasa u kojem se nalazi. Ako zelimo da pozovemo metodu iz private klase u drugoj classi nece raditi.
            //protected - modifikator koji daje dozvolu da se moze pristupiti kodu samo ta klasa u kojoj se nalazi ili u klasi koja ju nasljedjuje (inherited).
            //internal - modifikator koji daje dozvolu da se moze pristupiti kodu samo ta klasa u kojoj se nalazi ili bilo koja druga klasa u tom prjektu.
            
        }
    }
}