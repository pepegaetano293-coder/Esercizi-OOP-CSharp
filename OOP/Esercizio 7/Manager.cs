using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Dipendenti
{
    internal class Manager: Dipendente
    {
        public double Extra;

        public Manager(string Nome, double SalarioBase,double Extra): base(Nome, SalarioBase)
        {
            this.Extra = Extra;
        }
        public override void CalcoloStipendio()
        {
            SalarioBase = SalarioBase + Extra;
            Console.WriteLine($"Il salario base del Manager è pari a {SalarioBase}€");
        }

    }
}
