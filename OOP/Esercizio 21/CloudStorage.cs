using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_21
{
    internal class CloudStorage:IStorage
    {
        public void SalvoDati(string dati)
        {
            Console.WriteLine($"Invio dati al server AWS in corso: {dati}");
        }
    }
}
