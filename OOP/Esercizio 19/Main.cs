using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_19
{
    internal class MultiCanale
    {
        static void Main_MultiCanale(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Esercizio 19: Multicanale.
            // Il problema: Un sito di e-commerce deve accettare pagamenti tramite diversi metodi
            // (Carta di Credito, PayPal, BitCoin). Ogni metodo ha un modo diverso di "autorizzare"
            // la transazione.

            // (1) Crea l'interfaccia IPagamento con il metodo "void ProcessoPagamento(double importo)".

            // (2) Crea la classe "PagamentoCarta".
            // (2.1) Deve avere una proprietà NumeroCarta. Il metodo stampa "Pagamento di {importo} effettuato con Carta {numero}"

            // (3) Crea la classe "PagamentoPayPal".
            // (3.1) Deve avere una proprietà Email. Il metodo stampa "Pagamento di {importo} effettuato tramite account {email}"
            // (4) Còasse "ProcessoreOrdini"
            // (4.1) Metodo FinalizzaOrdine(IPagamento metodo, double totale).
            // Questo metodo deve stampare "Validazione ordine in corso..."
            // e poi chiamare il metodo ProcessaPagamento dell'interfaccia.

            ProcessoreOrdini ordine = new ProcessoreOrdini(100);

            IPagamento Carta = new PagamentoCarta(29573058);
            IPagamento PayPal = new PagamentoPayPal("gianluca@gmail.com");

            ordine.FinalizzoOrdine(Carta, 100);
            ordine.FinalizzoOrdine(PayPal, 100);
        }

       
    }
}
