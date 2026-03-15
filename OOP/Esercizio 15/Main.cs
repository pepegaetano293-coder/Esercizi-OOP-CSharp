using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_15
{
    internal class Notifica
    {
        static void Main_Notifica(string[] args)
        {
            // Esercizio 15: Interfaccia di Notifica.
            // Obiettivo: Implementa il polimorfismo tramite interfacce.
            // (1) Definisci un'interfaccia "INotificatore" con metodo Invia(string messaggio).
            // (2) Implementa due classe che ereditano da questa interfaccia:
            // (2.1) "EmailNotificatiore": stampa a console "Invio Email: [messaggio]"
            // (2.2) "SMSNotificatore": stampa a console "Invio SMS: [messaggio]"
            // (3) Crea una classe Gestore Avvisi che abbia un metodo EseguiNotifica(INotificatore notificatore, string msg).
            // Questo passaggio deve chiamare il comando Invia dell'oggetto passato.

            GestoreAvvisi avvisi = new GestoreAvvisi();
            INotificatore miaEmail = new EmailNotificatore();
            INotificatore mioSMS = new SMSNotificatore();

            avvisi.EseguiNotifica(miaEmail, "Ciao, sono una Email");
            avvisi.EseguiNotifica(mioSMS, "Ciao, sono un SMS");
        }
    }
}
