using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_10
{
    abstract internal class DispositivoElettrico
    {
        abstract public bool isAcceso { get; set; }
        public abstract void Accendi();
        public abstract void Spegni();
        public void MostraStato()
        {
            if(isAcceso == true) Console.WriteLine("Dispositivo acceso");
            else Console.WriteLine("Dispositivo spento");
        }
    }
}
