using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_18
{
    internal interface IStrategiaSconto
    {
        double ApplicoSconto(double prezzoIniziale);
    }
}
