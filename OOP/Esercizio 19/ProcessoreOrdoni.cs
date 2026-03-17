using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_19
{
    internal class ProcessoreOrdini
    {
       public double Totale { get; set; }
        public ProcessoreOrdini(double Totale)
        {
            this.Totale = Totale;
        }
        public void FinalizzoOrdine(IPagamento metodo, double Totale)
        {
            Console.WriteLine("Validazione ordine in corso...");
            metodo.ProcessoPagamento(Totale);

        }
    }
}
