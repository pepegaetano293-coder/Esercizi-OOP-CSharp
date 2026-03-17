using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_20
{
    internal class SensoreLuce:ISensore
    {
        public string Nome { get; } = "Sensore di luce";
        public double LeggiValore()
        {
            Random r = new Random();
            return r.Next(0, 101);
        }
    }
}
