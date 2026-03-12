using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Prodotto
{
    class OOP
    {
        static void Main_Prodotto(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Esercizio 4. Il Gestore "Prodotto"
            // (1) Crea una classe "Prodotto".
            // (2) Campi privati: _nome(string), _prezzo(double).
            // (3) Proprietà con Logica(Getters & Setters):
            // (3.1) Nome: Sola lettura(solo get).
            // (3.2) Prezzo: Deve avere un set che controlla: se il valore è minore di 0, imposta il prezzo a 0 e stampa un avviso.
            // (4) Costruttore: Accetta nome e prezzo.
            // (5) Metodo: ApplicaSconto(int percentuale) che riduce il prezzo.
            // (6) Nel Main: Crea un prodotto con prezzo - 10 e vedi se il tuo "Setter" lo corregge automaticamente a 0.

            Prodotto prodotto = new Prodotto("Deodorante", -10);
            Console.WriteLine($"Nome: {prodotto.Nome}, prezzo attuale: {prodotto.Prezzo}€");

            prodotto.ApplicoSconto(10);
        }
    }
}
