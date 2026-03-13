using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_10
{
    internal class Televisore : DispositivoElettrico
    {
        private int _canale;
        public int Canale
        {
            get { return _canale; }
            set
            {
               if (value >= 0)
                {
                    _canale = value;
                    Console.WriteLine("Canale OK");
                }
                else
                {
                    Console.WriteLine("Un canale non può essere negativo");
                    _canale = 0;
                }

            }
            
        }
        

        public Televisore(int canaleIniziale)
        {
            this.Canale = canaleIniziale;
        }
        public override bool isAcceso { get ; set ; }

        public override void Accendi()
        {
            isAcceso = true;
            Console.WriteLine("La TV è accesa");
        }

        public override void Spegni()
        {
            isAcceso = false;
            Console.WriteLine("La TV è spenta.");
        }
    }
}
