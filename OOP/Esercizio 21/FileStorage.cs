using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_21
{
    internal class FileStorage:IStorage
    {
        public void SalvoDati(string dati)
        {
            Console.WriteLine($"Scrittura dati nel file 'Documento.txt': {dati}");
        }
    }
}
