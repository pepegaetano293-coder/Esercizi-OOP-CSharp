using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Conto_Corrente
{
    internal class Conto_Bancario_Ex
    {
        static void Main_CC(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Esercizio 2
            // (1) Crea una classe "ContoBancario"
            // (2) Aggiungi un campo privato "_saldo" (double).
            // (3) Aggiungi una proprietà solo lettura "Saldo" che restituisce il valore di _saldo.
            // (4) Crea un costruttore che accetti un parametro per impostare il saldo iniziale.
            // (5) Aggiungi due metodi:
            // (5.1) Deposita(double importo): Aggiunge l'importo al saldo.
            // (5.2) Preleva (double importo): sottrae l'importo dal saldo, ma solo se l'importo è disponibile (altrimenti stampa un errore.
            // (6) Nel Main: Crea un conto con 500€. Prova a prelevare 600€ (deve fallire). Deposita 200€ e poi preleva 100€ (deve funzionare). 
            // Stampa il saldo finale
            Conto_Bancario conto = new Conto_Bancario(500);
            
            conto.Deposita();
        }
    }
}
