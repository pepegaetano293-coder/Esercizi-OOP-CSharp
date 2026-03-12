using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Libro
{
    class OOP
    {
        static void Main_Libro(string[] args)
        {
            // Esercizio 1: Il Modello "Libro".
            // Obiettivo: Creare una classe semplice, usare i campi e un metodo di istanza
            // (1) Crea una classe chiamata "Libro"
            // (2) Aggiungi tre campi pubblici: Titolo, Autore e Pagine.
            // (3) Aggiungi un metodo chiamato Descrizione() che stampi in console una frase come:
            // "Il libro 'Titolo' è stato scritto da 'Autore' e ha 'Pagine' pagine".
            // (4) Nel Main del programma: istanzia un oggetto Libro; Assega dei valori ai suoi campi; Invoca il metodo Descrizione().

            Libro libro1 = new Libro("Introversi e felici", "Sylvia Lohken", 275);

            libro1.Descrizione();

        }
    }
}