using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_17
{
    internal class Animali
    {
        static void Main_Animali(string[] args)
        {
            // Esercizio 18 Animali e versi
            // (1) Crea una classe astratta Animale con una proprietà "Nome" e un metodo astratto "FaiVerso()"
            // (2) Crea le classi Cane e Gatto che ereditano da Animale
            // (3) Implementa il metodo FaiVerso() in modo che stampino rispettivaente "Bau!" e "Miao!"

            Cane cane = new Cane();
            Gatto gatto = new Gatto();

            cane.FaiVerso();
            gatto.FaiVerso();
        }
    }
}
