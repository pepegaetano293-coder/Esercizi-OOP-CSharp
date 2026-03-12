using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Libro
{
    internal class Libro
    {
        public string Titolo;
        public string Autore;
        public int Pagine;

        public Libro(string Titolo, string Autore, int Pagine)
        {
            this.Titolo = Titolo;
            this.Autore = Autore;
            this.Pagine = Pagine;
        }

        public void Descrizione()
        {
            Console.WriteLine($"Il libro '{Titolo}' è stato scritto da '{Autore}' e ha {Pagine} pagine.");
            
        }


    }
}
