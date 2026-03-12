using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Registro
{
    internal class RegistroAlunni
    {
        static void Main_Registro(string[] args)
        {
            // Esercizio 3. Registro "Studenti"
            // (1) Crea una classe "Studente"
            // (2) Aggiungi le proprietà "Nome" e "Voto"
            // (3) Crea due costruttori, di cui:
            // (3.1) Uno che accetti sia Nome che Voto.
            // (3.2) Uno che accetta solo Nome (e assegna un voto predefinito di 0).
            // (4) Nel Main: Crea una List<Studente>. Aggiungi alla lista 3 studenti diversi usando entrambi i costruttori.
            // Usa un ciclo "foreach" per stampare il nome di ogni studente e se è promosso o meno (voto >= 6).

            List<Studente> studenti = new List<Studente>();
            Studente s1 = new Studente("Marco", 8);
            Studente s2 = new Studente("Gae");
            Studente s3 = new Studente("Elena", 2);

            studenti.Add(s1);
            studenti.Add(s2);
            studenti.Add(s3);

            foreach(Studente item in studenti)
            {
                if(item.Voto >=6) Console.WriteLine($"{item.Nome} = {item.Voto} => Promosso");
                else Console.WriteLine($"{item.Nome} = {item.Voto} => Bocciato");
            }





        }
    }
}
