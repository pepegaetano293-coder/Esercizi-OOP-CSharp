using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Dipendenti
{
    internal class Dipendente
    {
        public string Nome;
        public double SalarioBase;

        public Dipendente(string Nome, double SalarioBase)
        {
            this.Nome = Nome;
            this.SalarioBase = SalarioBase;
        }
        public virtual void CalcoloStipendio()
        {
            Console.WriteLine($"Il salario base del dipendente è {SalarioBase}€");
        }
    }
}
