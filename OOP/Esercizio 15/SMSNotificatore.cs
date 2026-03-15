using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_15
{
    internal class SMSNotificatore:INotificatore
    {
        public void Invia(string Messaggio)
        {
            Console.WriteLine($"Invio SMS: {Messaggio}");
        }
    }
}
