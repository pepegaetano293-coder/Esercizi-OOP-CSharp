using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_22
{
    internal class Notifiche
    {
        static void Main(string[] args)
        {
            // Esercizio 22. Sistema di notifiche
            // Devi simulare un sistema che invia avvisi agli utenti.

            // (1) Crea un'interfaccia IInviabile con un metodo Invio(string messaggio)
            // (2) Crea una classe astratta Notifica che implementa IInviabile.
            // Aggiungi una proprietà Destinatario e un metodo astratto VisualizzaLog().
            // (3) Crea le classi concrete Email e SMS che ereditano da Notifica.
            // (4) Implementa Invio() in modo che stampi il tipo di notifica e il destinatario.
            // Implementa VisualizzaLog() per mostrare l'orario di invio (usa DateTime.Now)

            IInviabile mail = new Email("Lucarossi777@esempio.it");
            IInviabile sms = new SMS("3859287479");

            List<IInviabile> lista = new List<IInviabile> { mail, sms };

            foreach(var p in lista)
            {
                p.Invio("Ciao, come va?");
                if(p is Notifica notifica)
                {
                    notifica.VisualizzaLog();
                }
            }


        }
    }
}
