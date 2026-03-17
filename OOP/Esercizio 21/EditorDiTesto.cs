using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_21
{
    internal class EditorDiTesto
    {
        public string Contenuto;
        public EditorDiTesto(string Contenuto)
        {
            this.Contenuto = Contenuto;
        }
        public void EseguiSalvataggio(IStorage supporto)
        {
            supporto.SalvoDati(Contenuto);
        }
    }
}
