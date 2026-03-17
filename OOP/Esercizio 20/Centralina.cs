using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_20
{
    internal class Centralina
    {
        private List<ISensore> _sensori;
        public Centralina()
        {
            _sensori = new List<ISensore>();
        }
        public void AggiungiSensore(ISensore s)
        {
            _sensori.Add(s);
        }
        public void MonitoraCasa()
        {
            foreach (ISensore s in _sensori)
            {
                Console.WriteLine($"Il sensore {s.Nome} segna il valore {s.LeggiValore()}.");
            }
        }
    }
}
