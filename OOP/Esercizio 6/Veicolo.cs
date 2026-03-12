using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Garage_Ex
{
    internal class Veicolo
    {
        public string Marca;
        public string Modello;
        public string Targa;
        public Veicolo (string Marca, string Modello, string Targa)
        {
            this.Marca = Marca;
            this.Modello = Modello;
            this.Targa = Targa;
        }
        
    }
}
