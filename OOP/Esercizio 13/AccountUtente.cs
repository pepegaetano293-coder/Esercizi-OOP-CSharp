using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_13
{
    internal class AccountUtente
    {
        public string Username { get; init; }

        public string Email { get; init; }

        public int LivelloPermessi { get; init; }
        // Utilizzando (get; init;), la proprietà può essere impostata nel costruttore
        // OPPURE
        // usando la sintassi con le graffe al momento della creazione (vedi Main).
        public AccountUtente(string Username, string Email, int LivelloPermessi)
        {
            this.Username = Username;
            this.Email = Email;
            this.LivelloPermessi = LivelloPermessi;
        }
        public AccountUtente(string Username, string Email): this(Username,Email,1)
        {
            
        }
        public AccountUtente(string Email): this(Email.Split('@')[0], Email) // <- .Split permette di tagliare una stringa ogni volta che vedere un determinato carattere.
                                                                             // In questo caso taglia la stringa ogni volta che vede '@', ottenendo un array
                                                                             // di due pezzi: Pezzo[0]: La prima parte della email (sx). Pezzo[1]: La seconda parte (dx).

        {
            
        }
    }
}
