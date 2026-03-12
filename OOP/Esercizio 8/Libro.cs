using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Biblioteca_Ex
{
    internal class Libro
    {
        public string Titolo;
        public string Autore;
        public bool IsDisponibile;
        public Libro(string Titolo, string Autore, bool IsDisponibile)
        {
            this.Titolo = Titolo;
            this.Autore = Autore;
            this.IsDisponibile = true;
        }
    }
}
