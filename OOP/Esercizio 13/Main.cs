using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_13
{
    internal class Costruttore_a_catena
    {
        static void Main_Costruttore(string[] args)
        {
            // Esercizio 13. Il Pattern "Costruttore a catena"
            // (1) Crea una classe "AccountUtente"
            // (1.1) Deve avere tre proprietà: Username (string), Email (string) e LivelloPermessi (int)
            // (1.2) Le proprietà deve essere solo di lettura.
            // (1.3) Implementa tre costruttori:
            // Un costruttore "Master" che accetta tutti e tre i parametri.
            // Un secondo costruttore che accetta Username ed Email, che imposta il LivelloPermessi a 1(default)
            // richiamando il cotruttore Master tramite ":this(...)"
            // Un terxo costruttore che accetti solo Email, che imposta lo Username come parte dell'email prima dell "@"
            // e il livello a 1, richiamando il secondo costruttore.

            // (2) nel Main, istanzia tre utenti usando i tre diversi costruttori e stampa i dettagli.

            AccountUtente utente1 = new AccountUtente("Aurelio", "AurelioDelRegno93@gmail.com", 10);
            AccountUtente utente2 = new AccountUtente("Admin74", "PieroDelPiero@gmail.com");
            AccountUtente utente3 = new AccountUtente("OrsoBear@hotmail.com");

            Console.WriteLine($"Utente 1: {utente1.Username}, Livello: {utente1.LivelloPermessi}");
            Console.WriteLine($"Utente 2: {utente2.Username}, Livello: {utente2.LivelloPermessi}");
            Console.WriteLine($"Utente 3: {utente3.Username}, Livello: {utente3.LivelloPermessi}");
        }
    }
}
