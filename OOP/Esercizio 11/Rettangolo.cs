using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_11
{
    internal class Rettangolo : Forma
    {
        public double Base;
        public double Altezza;

        public Rettangolo(double Base, double Altezza)
        {
            this.Base = Base;
            this.Altezza = Altezza;
        }
        public override void CalcoloArea()
        {
            double risultato = Base * Altezza;
            Console.WriteLine($"L'area del rettangolo è pari a {risultato}.");
        }
    }
}
