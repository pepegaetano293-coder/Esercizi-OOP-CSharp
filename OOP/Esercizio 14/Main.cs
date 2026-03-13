using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_14
{
    internal class Veicoli
    {
        enum TipoAlimentazione
        {
            Benzina, Diese, Elettrico, Ibrido
        }
        static void Main(string[] args)
        {

            // Esercizio 14: Gestione Veicoli:
            // (1) Crea un enum Tipolaminetazione con i valori: Benzina, Diesel, Elettrica, Ibrido.

            // (2) Crea una classe base Veicolo con:
            // Proprietà Marca e Modello.
            // Un metodo "Acceso che stampa "Il veicolo è acceso."

            // (3) Crea una classe derivata Auto che eredita da Veicolo:
            // Aggiungi la proprietà Alimentazione (di TipoAlimentazione).
            // Esegui Override del metodo Accendi() per stampare "L'auto [Marca] [Modello] a [Alimentazione] è pronta a partire".

            // (4) Nel Main, istanzia un'auto elettrica e chiama il metodo Accendi().

            Auto miaAuto = new Auto("Toyota", "Yaris", Esercizio_14.TipoAlimentazione.Elettrico);

            miaAuto.Accendi();
            
        }
    }
}
