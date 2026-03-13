using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_10
{
    internal class Smarthphone : DispositivoElettrico
    {
        public int PercentualeBatteria;
        public string Marca;
        public override bool isAcceso { get; set; }

        public Smarthphone(string Marca ,int percentualeBatteria)
        {
            this.PercentualeBatteria = PercentualeBatteria;
            this.isAcceso = isAcceso;
            this.Marca = Marca;
        }

        public override void Accendi()
        {
            isAcceso = true;
            Console.WriteLine("Cellulare acceso");
        }

        public override void Spegni()
        {
            isAcceso = false;
            Console.WriteLine("Cellulare spento");
        }
    }
}
