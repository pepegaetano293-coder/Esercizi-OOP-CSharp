using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_12
{
    internal class ProdottoFisico: ISpedibile 
    {
        public string Nome;
        public double Peso;
        public ProdottoFisico()
        {
            this.Nome = Nome;
            this.Peso = Peso;
        }
        public double CalcoloCostoSpedizione()
        {
            return Peso * 2;
            
        }
    }
}
