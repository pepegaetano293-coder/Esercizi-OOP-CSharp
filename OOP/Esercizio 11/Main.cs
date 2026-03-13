using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_11
{
    internal class Geometria
    {
       static void MainGeometria(string[] args)
        {
            // Esercizio 11: Geometria
            // (1) Crea una classe astratta "Forma"
            // (1.1) Metodo astratto: CalcoloArea() (deve restituire un double)

            // (2) Crea la classe "Rettangolo".
            // (2.1) Proprietà: Base e Altezza.
            // (2.2) Override di CalcoloArea() (Base * Altezza)

            // (3) Crea la classe "Cerchio".
            // (3.1) Proprietà "Raggio".
            // (3.1) Override di CalcoloArea (pigreco * Raggio^2). Suggerimento: Usa Math.PI

            Forma[] Figure = new Forma[2];
            Figure[0] = new Rettangolo(7.24, 8.57);
            Figure[1] = new Cerchio(10.24);

            foreach(Forma item in Figure)
            {
                item.CalcoloArea();
            }


        }
    }
}
