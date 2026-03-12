using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Biblioteca_Ex
{
    class Biblio
    {
        static void Main_Biblioteca(string[] args)
        {
            // Esercizio 8: Gestione Biblioteca
            // (1) Classe Libro: 
            // (1.1) Proprietà: Titolo (string), Autore (string), IsDisponibile (bool)
            // (1.2) Costruttore che imposta "IsDisponibile" a true di default.

            // (2) Classe Biblioteca:
            // (2.1) Lista privata di Libro
            // (2.2) Metodo AggiungiLibro(Libro 1).
            // (2.3) Metodo PrestitoLibro (string titolo): cerca il libro nella lista.
            // Se esiste ed è disponibile, imposta "IsDisponibile" = false. Se non esiste o è già in prestito, stampa un errore.

            // (3) Main:
            // (3.1) Crea una biblioteca con 3 libri.
            // (3.2) Prova a prendere in prestito lo stesso libro due volte e osserva cosa succede. 

            Biblioteca biblioteca = new Biblioteca();
            Libro libro1 = new Libro("IT", "Steven Hawkings", true);
            Libro libro2 = new Libro("Introversi e Felici", "Silvya Hawken", true);
            Libro libro3 = new Libro("La botanica degli amori perduti", "Claire Elder", true);

            biblioteca.AggiungiLibro(libro1);
            biblioteca.AggiungiLibro(libro2);
            biblioteca.AggiungiLibro(libro3);

            Console.WriteLine("----- Tentativo 1 -----");
            biblioteca.PrestitoLibro("Introversi e Felici");
            Console.WriteLine("----- Tentativo 2 -----");
            biblioteca.PrestitoLibro("Introversi e Felici");
            Console.WriteLine("----- Tentativo 3 -----");
            biblioteca.PrestitoLibro("IT");
            Console.WriteLine("----- Tentativo 4 -----");
            biblioteca.PrestitoLibro("Bibbia");


        }
    }
}
