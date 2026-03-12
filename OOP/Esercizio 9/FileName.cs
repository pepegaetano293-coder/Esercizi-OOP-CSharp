using CorsoCSharp.OOP.Esercizio_9;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Gioco
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            // Esercizio 9: Videogioco "Personaggi
            // Obiettivo: Far interagire due oggetti tra loro modificando i propri stati interni.
            // (1) Classe Personaggio.
            // (1.1) Proprietà "Nome" string, "PuntiVita" int.
            // (1.2) Costruttore: Inizializza Nome e imposta PuntiVita a 100.
            // (1.3) Metodo RiceviDanno (int danno): sottrae il danno dai PuntiVita. 
            // Se scendono sotto 0, impostali a 0.
            // (1.4) Metodo Attacco (Personaggio bersaglio): genera un numero casuale (es.tra 5 e 20) e chiama RiceviDanno sul bersaglio.

            // (2) Nel Main:
            // (2.1) Crea due personaggi: "Guerriero" e "Mago".
            // (2.2) Fai in modo che il Guerriero attacchi il Mago.
            // Stampa i PuntiVita del Mago dopo l'attacco.

            Personaggio Guerriero = new Personaggio("Gaetano", 100);
            Personaggio Mago = new Personaggio("Samu", 100);
            
            while(Guerriero.PuntiVita > 0 && Mago.PuntiVita > 0)
            {
                Guerriero.Attacco(Mago);
                if(Mago.PuntiVita > 0)
                {
                    Mago.Attacco(Guerriero);
                    Console.WriteLine($"Situazione: {Guerriero.Nome} ({Guerriero.PuntiVita} HP) | {Mago.Nome} ({Mago.PuntiVita} HP)");
                }
            }
            if (Guerriero.PuntiVita > 0) Console.WriteLine($"{Guerriero.Nome} VINCE!");
            else Console.WriteLine($"{Mago.Nome} VINCE!");
        }
    }
}
