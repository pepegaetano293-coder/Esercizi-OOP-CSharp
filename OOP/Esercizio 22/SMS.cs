using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_22
{
    internal class SMS : Notifica
    {
        public SMS(string destinatario): base(destinatario) { }

        public override void Invio(string messaggio)
        {
            Console.WriteLine($"[SMS] Inviato al numero{Destinatario}: {messaggio}.");
        }
        public override void VisualizzaLog()
        {
            Console.WriteLine($"Notifica inviata alle ore {DateTime.Now}.");
        }
   
    }
}
