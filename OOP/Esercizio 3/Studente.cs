using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Registro
{
    internal class Studente
    {
        public string Nome;
        public int Voto;

        public Studente(string Nome, int Voto)
        {
            this.Nome = Nome;
            this.Voto = Voto;
        }
        public Studente(string Nome) : this(Nome,0) // Permette di concatenare questo costruttore al costruttore pincipale (il primo).
                                                    // Inoltre, posso lasciare un vuoto nelle parentesi graffe.
                                                    // Avrei potuto scrivere "this.Nome = Nome" e "this.Voto = 0;" ma, se la classe diventa complessa
                                                    // (magari con 10 proprietà), dovrei andare a riscrivere 1' righe di codice in ogni costruttore.
        {

        }
    }
}
