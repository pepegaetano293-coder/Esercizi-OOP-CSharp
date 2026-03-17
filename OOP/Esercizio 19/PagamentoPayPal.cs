using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_19
{
    internal class PagamentoPayPal:IPagamento
    {
        private string _email;
        public PagamentoPayPal(string Email)
        {
            _email = Email;
        }
        public void ProcessoPagamento(double importo)
        {
            Console.WriteLine($"Pagamento di {importo} effettuato tramite account {_email}.");
        }
    }
}
