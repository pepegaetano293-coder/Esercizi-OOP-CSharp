using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_9
{

    internal class Personaggio
    {
        public string Nome;
        public int PuntiVita;
        private Random _rdn = new Random(); // <- Mi permette di creare un valore casuale
        public Personaggio(string Nome, int PuntiVita)
        {
            this.Nome = Nome;
            this.PuntiVita = 100;
        }
        public void RiceviDanno(int danno)
        {
            this.PuntiVita = this.PuntiVita - danno;
            if(PuntiVita < 0)
            {
                this.PuntiVita = 0;
            }
        }
        public void Attacco(Personaggio Bersaglio)
        {
            int danno = _rdn.Next(5, 21);
            Bersaglio.RiceviDanno(danno);
            Console.WriteLine($"{this.Nome} attacca {Bersaglio.Nome} infliggendo {danno} danni!");
        }
    }
}
