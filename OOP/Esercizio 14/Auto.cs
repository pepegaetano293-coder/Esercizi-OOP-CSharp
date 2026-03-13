using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_14
{
    enum TipoAlimentazione
    {
        Benzina, Diese, Elettrico, Ibrido
    }
    internal class Auto: Veicolo
    {
        public TipoAlimentazione Alimentazione { get; set; }
        public Auto(string Marca, string Modello, TipoAlimentazione Alimentazione): base(Marca, Modello)
        {
            this.Alimentazione = Alimentazione;
        }
        public override void Accendi()
        {
            Console.WriteLine($"L'auto {Marca} {Modello} a {Alimentazione} è pronta a partire");
        }
    }
}
