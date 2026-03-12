using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Biblioteca_Ex
{
    internal class Biblioteca
    {
        private List<Libro> _libro;
        public Biblioteca()
        {
            _libro = new List<Libro>();
        }
        public void AggiungiLibro(Libro c)
        {
            _libro.Add(c);
        }
        public void PrestitoLibro(string titolo)
        {
            foreach(Libro c in _libro)
            {
                if(titolo == c.Titolo) // <- Ricordati che "c" è un oggetto che ha diverse proprietà
                {
                    if (c.IsDisponibile)
                    {
                        c.IsDisponibile = false;
                        Console.WriteLine("Prestito effettuato!");
                    }else Console.WriteLine("Già in prestito.");
                    return; // <- Lo utilizzo in quanto il libro è stato trovato ed esco dal metodo
                }
                
            }
            Console.WriteLine("Libro non presente in catalogo!");
        }
    }
}
