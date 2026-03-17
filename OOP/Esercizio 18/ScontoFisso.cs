using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_18
{
    internal class ScontoFisso:IStrategiaSconto
    {
        private double _sconto;
        public ScontoFisso(double sconto)
        {
            _sconto = sconto;
        }
        public double ApplicoSconto(double prezzoIniziale)
        {
            return prezzoIniziale - _sconto;
        }
    }
}
