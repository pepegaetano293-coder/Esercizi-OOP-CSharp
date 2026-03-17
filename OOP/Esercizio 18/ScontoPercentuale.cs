using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_18
{
    internal class ScontoPercentuale:IStrategiaSconto
    {
        private double _sconto;
        public ScontoPercentuale(double sconto)
        {
            _sconto = sconto;
        }
        public double ApplicoSconto(double prezzoIniziale)
        {
            return prezzoIniziale - (prezzoIniziale * _sconto/100);
        }
    }
}
