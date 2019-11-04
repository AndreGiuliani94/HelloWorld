using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person                                                            //definizione classe    
    {
        public string nome;                                                //variabili di classe
        public string cognome;
        public int età;
        public string sesso;
        public double altezza;
        public double peso;


        public Person(string nome, string cognome, double altezza, double peso)                      
        {
            this.nome = nome;                                           
            this.cognome = cognome;
            this.sesso = "Sconosciuto";
            this.altezza = altezza;
            this.peso = peso;

        }


        public double CalcoloBMI()
        {
            double BMI;
            if (this.peso != 0 && this.altezza != 0)
            { 
                BMI = this.peso / (this.altezza * this.altezza); }
            else { BMI = -1}; 
            
            return BMI;
        }
        public string Anagrafica()                                     
        {
            string anagrafica = this.nome + " " + this.cognome;

            return anagrafica;
        }
    }
}
