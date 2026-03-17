using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_20
{
    internal interface ISensore
    {
        public string Nome { get; }
        public double LeggiValore();
    }
}
