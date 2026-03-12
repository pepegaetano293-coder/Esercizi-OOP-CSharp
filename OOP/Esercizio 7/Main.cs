using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Dipendenti
{
    class Dipendenti
    {
        static void Main_Dipendenti(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Esercizio 7: Sistema "Dipendenti"
            // (1) Classe Madre Dipendente:
            // (1.1) Proprietà: "Nome" string, "SalarioBase"(double)
            // (1.2) Costruttore che inizializza intrambi.
            // (1.3) Metodo CalcoloStipendio(): restituisce il SalarioBase.

            // (2) Classe Figlia Manager:
            // (2.1) Eredita da Dipendente)
            // (2.2) Proprietà extra: "Bonus" (double)
            // (2.3) Metodo CalcoloStipendio(): deve restituire SalarioBase + Bonus.

            // (3) Nel Main:
            // (3.1) Creare una List<Dipendente>.
            // (3.2) Aggiungi alla lista un Dipendente normale e un Manager.
            // (3.3) Cicla la lista e stampa il nome di ognuno e lo stipendio calcolato
            // (il programma userà automaticamente il calcolo giusto per il Manager!).

            List<Dipendente> componenti = new List<Dipendente>();
            Dipendente lavoratore = new Dipendente("Gaetano", 1450.00);
            Manager capo = new Manager("Giuseppe", 1350, 250);

            componenti.Add(lavoratore);
            componenti.Add(capo);

            foreach(Dipendente item in componenti)
            {
                item.CalcoloStipendio();  
            }

        }
    }
}
