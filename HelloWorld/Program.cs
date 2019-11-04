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

                                                                            // reference type string array oblject

            string insiemeDiCaratteri;

            string stringa1 = "la mia casa è bella";
            string stringa2 = stringa1;

            Console.WriteLine(stringa1);
            Console.WriteLine(stringa2);

            stringa1 = "la mia casa è brutta";

            Console.WriteLine(stringa1);
            Console.WriteLine(stringa2);

            object oggetto;

            Person luca = new Person("Luca", "Lippi", 1.80, 80);                     //ho ISTANZIATO un nuovo oggetto Person

            if (luca.altezza !=0 && luca.peso !=0)
            {
                Console.WriteLine("Il BMI di " + luca.Anagrafica() + " è " + luca.CalcoloBMI());
            }
            else
                Console.WriteLine("Il BMI è -1");
        }
    }
}
