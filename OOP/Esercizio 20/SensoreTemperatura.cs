using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_20
{
    internal class SensoreTemperatura: ISensore
    {

        public string Nome { get; } = "Sensore di Temperatura";
        public double LeggiValore()
        {
            Random r = new Random();
            return r.Next(18, 31);
        }
    }
}
