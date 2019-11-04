using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person                                                    //definizione classe    
    {
        public string nome;                                                //variabili di classe
        public string cognome;
        public int età;
        public string sesso;
        public int altezza;
        public double pesso;

        public Person(string nome, string cognome)                  //definizione metodi con relativa FIRMA
        {
            this.nome = nome;                                       //ambiguità nome variabile, usare this. per riferirsi alla variabile di classe
            this.cognome = cognome;
            this.sesso = "Sconosciuto";
        }


        public Person(string nome)
        {
        }

        public Person()                                             //costruttore vuoto
        {
        }

        public string Anagrafica()
        {
            string anagrafica = this.nome + " " + this.cognome;

            return anagrafica;
        }
    }
}
