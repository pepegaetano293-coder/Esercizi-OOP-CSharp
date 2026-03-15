using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_16
{
    internal class negozio
    {
        private List<Prodotto> _prodotto;
        public negozio()
        {
            _prodotto = new List<Prodotto>();
        }
        public void AggiungiProdotto(Prodotto p)
        {
            _prodotto.Add(p);
        }
        public void StampaCatalogo()
        {
            foreach(Prodotto p in _prodotto)
            {
                Console.WriteLine($"Oggetto rimasto: {p.Nome}. Valore torale in magazzino: {p.Prezzo * p.QuantitaInMagazzino}.");
            }
        }
    }
}
