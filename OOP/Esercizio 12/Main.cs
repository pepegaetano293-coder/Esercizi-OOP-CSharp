using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_12
{
    internal class Logistica
    {
        static void MainLogistic(string[] args)
        {
            // Esercizio 12: Il sistema di Logistica.
            // (1) Crea un'intefaccia "Ispedibile"
            // (1.1) Deve avere un metodo CalcoloCostoSpedizione().

            // (2) Crea una classe ProdottoFisico (Proprietà: Nome, Peso).
            // (2.1) Implementa l'interfaccia: il costo è 2€ per ogni kg.

            // (3) Crea la classe AbbonamentoMensile (Proprietà: Nome, Prezzo).
            // (3.1) Implementa l'interfaccia: il costo di spedizione è sempre 0€ (è digitale)

            // (4) Main: crea una List<Ispedibile> che contenga entrambi e stampa
            // i costi di spedizione totali.

            List<ISpedibile> Lista = new List<ISpedibile>();
            ProdottoFisico oggetto1 = new ProdottoFisico{ Nome = "Patate", Peso = 5 };
            AbbonamentoMensile oggetto2 = new AbbonamentoMensile();

            Lista.Add(oggetto1);
            Lista.Add(oggetto2);

            foreach(ISpedibile item in Lista)
            {
                Console.WriteLine($"Spedizione a nome di {item.GetType().Name}: {item.CalcoloCostoSpedizione()} euro.");
            }
        }
    }
}
