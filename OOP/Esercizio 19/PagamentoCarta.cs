using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_19
{
    internal class PagamentoCarta: IPagamento
    {
        private int _numerocarta;
        public PagamentoCarta(int NumeroCarta)
        {
            _numerocarta = NumeroCarta;
        }
        public void ProcessoPagamento(double importo)
        {
            Console.WriteLine($"Pagamento di {importo} effettuato con Carta {_numerocarta}."); 
        }
    }
}
