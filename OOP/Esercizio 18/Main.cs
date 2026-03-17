using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_18
{
    internal class Sconti
    {
        static void MainSconti(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Esercizio 18: Sconti
            // (1) Crea un'interfaccio "IStrategiaSconto" con un metodo double ApplicoSconto(double prezzoIniziale).
            // (2) Implementa tre classi: 
            // (2.1) ScontoFisso: sottrae un valore fisso dal prezzo. (es. 5 euro)
            // (2.2) ScontoPercentuale: riduce il prezzo di una certa percentuale.(es. 20%)
            // (2.3) NessunScinto: restituisce il prezzo originale invariato.
            // (3) Crea una classe "Carrello" che ha una proprietà PrezzoTotale e un metodo
            // CalcoloPrezzoFinale(IStrategiaSconto strategia).

            Carrello mioCarrello = new Carrello(100.0);

            IStrategiaSconto Fisso = new ScontoFisso(25);
            IStrategiaSconto Percentuale = new ScontoPercentuale(40);
            IStrategiaSconto zero = new NessunSconto();

            Console.WriteLine($"Prezzo Originale: 100€");
            Console.WriteLine($"Con Sconto Fisso: {mioCarrello.CalcolaPrezzoFinale(Fisso)}€");
            Console.WriteLine($"Con Sconto Percentuale: {mioCarrello.CalcolaPrezzoFinale(Percentuale)}€");
            Console.WriteLine($"Senza Sconto: {mioCarrello.CalcolaPrezzoFinale(zero)}€");
        }
    }
}
