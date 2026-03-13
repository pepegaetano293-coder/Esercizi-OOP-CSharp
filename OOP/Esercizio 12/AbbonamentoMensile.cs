using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_12
{
    internal class AbbonamentoMensile : ISpedibile
    {
        public string Nome;
        public int Prezzo;
        public double CalcoloCostoSpedizione()
        {
            return 0;
        }
    }

}