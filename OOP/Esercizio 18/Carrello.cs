using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_18
{
    internal class Carrello
    {
        public double PrezzoTotale {  get; set; } 
        public Carrello(double totale)
        {
            this.PrezzoTotale = totale;
        }
        public double CalcolaPrezzoFinale(IStrategiaSconto strategia)
        {
            return strategia.ApplicoSconto(PrezzoTotale);
        }
    }
}
