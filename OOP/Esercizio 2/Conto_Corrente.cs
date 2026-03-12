using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Conto_Corrente
{
    internal class Conto_Bancario
    {
        private double _saldo;
        public double Saldo // Proprietà (solo lettura)
        {
            get { return _saldo; }
        }

        public Conto_Bancario(double saldoIniziale)
        {
            _saldo = saldoIniziale;
        }

        public void Deposita()
        {
            Console.WriteLine("Scrivi un importo da depositare");
            double risposta = double.Parse(Console.ReadLine());
            if(risposta > 0)
            {
                _saldo = _saldo + risposta;
                Console.WriteLine($"Adesso hai {_saldo}€.");
            }

        }
        public void Preleva(double importo)
        {
            if(importo <= _saldo)
            {
                double Saldo = _saldo - importo;
                Console.WriteLine($"Adesso il tuo Saldo totale è: {Saldo}€");
            }else Console.WriteLine("Errore");
            
        }
    } 

        
        
    
    
    
     
}
