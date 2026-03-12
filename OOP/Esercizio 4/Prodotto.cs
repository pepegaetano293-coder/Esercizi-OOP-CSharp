using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Prodotto
{
    internal class Prodotto
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; } 
        }
        private double _prezzo;

        public double Prezzo
        {
            get => _prezzo;
            set
            {
                if (value < 0)
                {
                    _prezzo = 0;
                    Console.WriteLine("Errore");
                }
                else _prezzo = value;
            }
            
            
        }
        public Prodotto(string Nome, double Prezzo)
        {
            this._nome = Nome;
            this.Prezzo = Prezzo;
        }
        public void ApplicoSconto(int percentuale)
        {
            Prezzo = Prezzo - (Prezzo * percentuale / 100);
            Console.WriteLine($"Hai applicato lo sconto del {percentuale}%");
        }
  

    }
}
