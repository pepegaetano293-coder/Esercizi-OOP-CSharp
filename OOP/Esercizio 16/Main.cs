using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_16
{
    internal class Negozio
    {
        static void Main(string[] args)
        {
            // Esercizio 16: Gestire collezione di oggetti e incapsulamento.
            // (1) Crea una classe "Prodotto" con le proprietà "Nome", "Prezzo", "QuantitaInNegozio"
            // (1.1) Un metodo "RiduciScorta(int quantita)" che sottrae il valore della scorta (aggiungi un controllo: non può andare sotto zero).

            // (2) Crea una classe "Negozio":
            // (2.1) Contiene una List<Prodotto>
            // (2.2) Un metodo AggiungiProdotto (Prodotto p).
            // (2.3) Un metodo StampaCatalogo() che elenca tutti i prodotti e il loro valore totale in magazzino (Prezzo * Quantità)

            negozio MioNegozio = new negozio();

            Prodotto prodotto1 = new Prodotto("Laptop", 1000, 7);
            Prodotto prodotto2 = new Prodotto("Spugna", 3.50, 14);
            Prodotto prodotto3 = new Prodotto("Action Figure", 17, 2);

            prodotto1.RiduciScorta(4);
            prodotto3.RiduciScorta(7);

            MioNegozio.AggiungiProdotto(prodotto1);
            MioNegozio.AggiungiProdotto(prodotto2);
            MioNegozio.AggiungiProdotto(prodotto3);

            MioNegozio.StampaCatalogo();

        }
    }
}
