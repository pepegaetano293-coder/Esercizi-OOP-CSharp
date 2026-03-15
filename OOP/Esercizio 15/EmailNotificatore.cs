using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CorsoCSharp.OOP.Esercizio_15
{
    internal class EmailNotificatore: INotificatore
    {
        public void Invia(string Messaggio)
        {
            Console.WriteLine($"Invio Email: {Messaggio}");
        }
    }
}
