using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_10
{
    internal class Elettronico
    {
        static void MainElettrico(string[] args)
        {
            // Esercizio 10. Simulatori di Dispositivi Elettronici
            // (1) Crea una classe astratta DispositivoElettronico.
            // (1.1) Stato: Una variabile booleana "isAcceso"
            // (1.2) Metodi astratti: Accendi() e Spegni().
            // (1.3) Metodo concreto: MostraStato() che stampa se il dispositivo è acceso o spento.

            // (2) Crea la classe Televisione che eredita da DispositivoElettrico.
            // (2.1) Implementa i metodi Accendi/Spegni cambiando lo stato di isAcceso
            // (2.2) Aggiungi una proprietà Canale (int) con validazione (non può essere negativo).

            // (3) Crea la classe Smartphone che eredita da DispositivoElettronico.
            // (3.1) Implementa i metodi Accendi/Spegni.
            // (3.2) Aggiungi una proprietà PercentualeBatteria (int)

            Smarthphone cellulare = new Smarthphone("Samsung", 47);
            cellulare.MostraStato();
            cellulare.Accendi();
            cellulare.MostraStato();

            Televisore TV = new Televisore(-49);
            TV.MostraStato();
            TV.Accendi();
            TV.MostraStato();


        }
    }
}
