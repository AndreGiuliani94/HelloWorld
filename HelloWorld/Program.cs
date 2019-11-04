using HelloWorld.Model;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // value type

            int intero;
            
            float razionale32;
            
            double razionale64;
            
            bool valoreLogico;
            
            char carattere;
            
            decimal valoreDecimale;

            // reference type

            string insiemeDiCaratteri;

            string stringa1 = "la mia casa è bella";
            string stringa2 = stringa1;

            Console.WriteLine(stringa1);
            Console.WriteLine(stringa2);

            stringa1 = "la mia casa è brutta";

            Console.WriteLine(stringa1);
            Console.WriteLine(stringa2);

            object oggetto;

            Person luca = new Person("Luca", "Lippi");                     //ho ISTANZIATO un nuovo oggetto Person
            luca.età = 18;

            Console.WriteLine(luca.Anagrafica());

            Person giovanni = luca;

            giovanni.nome = "Giovanni";

            Console.WriteLine(luca.Anagrafica());
            Console.WriteLine(giovanni.Anagrafica());





        }
    }
}
