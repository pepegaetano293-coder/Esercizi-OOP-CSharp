using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_22
{
    abstract internal class Notifica:IInviabile
    {
        public string Destinatario { get; set;  }
        public Notifica(string destinatario)
        {
            Destinatario = destinatario;
        }
        public abstract void Invio(string messaggio);
        public abstract void VisualizzaLog();

        
    }
    
}
