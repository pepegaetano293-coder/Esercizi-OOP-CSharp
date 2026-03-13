using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_11
{
    internal class Cerchio : Forma
    {
        public double Raggio;
        public Cerchio(double Raggio)
        {
            this.Raggio = Raggio;
        }
        public override void CalcoloArea()
        {
            double risultato = Math.PI * (Math.Pow(Raggio, 2));
            Console.WriteLine($"L'area del cerchio è pari a {risultato}.");
        }
    }
}
