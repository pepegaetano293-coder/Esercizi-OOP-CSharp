using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_16
{
    internal class Prodotto
    {
        public string Nome;
        public double Prezzo;
        private int _quantitaInMagazzino;
        public int QuantitaInMagazzino { get; set; }
        public Prodotto(string Nome, double Prezzo, int QuantitaInMagazzino)
        {
            this.Nome = Nome;
            this.Prezzo = Prezzo;
            this.QuantitaInMagazzino = QuantitaInMagazzino;
        }
        public void  RiduciScorta(int Quantita)
        {
            int Risultato = QuantitaInMagazzino - Quantita;
            if(Risultato < 0)
            {
                Console.WriteLine("ERRORE. La quantità in magazzino NON può essere minore di zero.");
            }else Console.WriteLine($"Scorta di {Nome} rimasta in magazzino: {Risultato}");
        }
    }
}
