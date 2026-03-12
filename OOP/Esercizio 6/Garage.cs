using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CorsoCSharp.OOP.Garage_Ex
{
    internal class Garage
    {
        private List<Veicolo> _veicoli;
        private int _capacitaMassima;
        public Garage(int capacitaScelta)
        {
            _veicoli = new List<Veicolo>();
            _capacitaMassima = capacitaScelta;
        }
        public void AggiungiVeicolo(Veicolo C)
        {
            if(_veicoli.Count < _capacitaMassima)
            {
                _veicoli.Add(C);
                Console.WriteLine("Veicolo parcheggiato");
            }else Console.WriteLine($"Garage completo! Impossibile parcheggiare la targa {C.Targa}");
        }
        public void StampaSituazione()
        {
            Console.WriteLine($"Occupati: {_veicoli.Count}/{_capacitaMassima}");
            foreach(Veicolo item in _veicoli)
            {
                Console.WriteLine($" -> {item.Marca}, {item.Modello}, {item.Targa}");
            }
        }
    }
}
