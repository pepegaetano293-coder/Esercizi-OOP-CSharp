using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_18
{
    internal class NessunSconto: IStrategiaSconto
    {
        public double ApplicoSconto(double prezzoIniziale)
        {
            return prezzoIniziale;
        }
    }
}
