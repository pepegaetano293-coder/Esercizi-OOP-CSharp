using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_14
{
    internal class Veicolo
    {
        public string Marca;
        public string Modello;
        public Veicolo(string Marca, string Modello)
        {
            this.Marca = Marca;
            this.Modello = Modello;
        }
        public virtual void Accendi()
        {
            Console.WriteLine("L'auto è accesa.");
        }
    }
}
