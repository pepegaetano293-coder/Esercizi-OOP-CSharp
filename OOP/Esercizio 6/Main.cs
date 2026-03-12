using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Garage_Ex
{
    class Garage_Ex
    {
        static void Main_Garage(string[] args)
        {
            // Esercizio 6: Il Gestore "Garage"
            // Crea un sistema dove un oggetto "Gaeage" gestisce una collezione di oggetti "Veicolo", con un controllo speciale sulla capacità massima.

            // (1) Crea la classe "Veicolo" con le seguenti proprietà: Marca(string), Modello(string), Targa(string).
            // (1.1) Costruttore: Inizializza tutte le proprietà

            // (2) Crea la classe "Garage" con campo privato _veicoli (una Lista<Veicolo>).
            // campo privato: _capactaMassima (un int).
            // (2.1) Metodo AggiungiVeicolo(Veicolo v):
            // Logica: Prima di aggiungere, controlla se il garage è pieno (se il numero di veicoli nella lista è minore della capacità massima).
            // Se c'è posto, aggiungi il veicolo e stampa "Veicolo parcheggiato".
            // Se è pieno, stampa "Garage completo! Impossibile parcheggiare la targa [Targa]".

            // (3) Metodo StampaSituazione():
            // Stampa quanti posti sono occupati su quelli totali (es: "Occupati: 2/5").
            // Elenca Marca, Modello e Targa di ogni auto presente.

            Garage garage = new Garage(2);

            Veicolo veicolo1 = new Veicolo("Toyota", "2016", "HB 123 AX");
            Veicolo veicolo2 = new Veicolo("Mazda", "2002", "IT 582 KY");
            Veicolo veicolo3 = new Veicolo("Citroen", "2000", "IT 447 NM");

            garage.AggiungiVeicolo(veicolo1);
            garage.AggiungiVeicolo(veicolo2);
            garage.AggiungiVeicolo(veicolo3);

            garage.StampaSituazione();
        }
    }
}
