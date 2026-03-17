using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_20
{
    internal class Sensori
    {
        static void Main_Sensori(string[] args)
        {
            // Esercizio 20: Sentori Smart Home
            // Problema: In una casa domotica hai diversi sensori
            // (Temperatura, Umidità, Luce).
            // Vuoi un sistema che legga i dati da tutti, indifferentemente dal tipo.

            // (1) Interfaccia "ISensore". Proprietà: string Nome {get; }. Metodo "double LeggiValore()"
            // (2) Classi Concrete: "SensoreTemperatura" LeggiValore() restituisce un numero casuale tra 18 e 30 gradi.
            // (2.1) "SensoreLuce": LeggiValore() restituisce un numero tra 0 e 100 (percentuale di luminosità).
            // (3) Classe Centralina: Contiene una List<ISensore>. Metodo "MonitoraCasa()": 
            // Cicla tutti i sensori e stampa: "Il sensore {Nome} segna il valore {Valore}.

            Centralina centralino = new Centralina();
            SensoreLuce Luce = new SensoreLuce();
            SensoreTemperatura temperatura = new SensoreTemperatura();

            centralino.AggiungiSensore(Luce);
            centralino.AggiungiSensore(temperatura);
            centralino.MonitoraCasa();

            

        }
    }
}
