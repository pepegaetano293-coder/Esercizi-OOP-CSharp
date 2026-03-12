using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Playlist
{
    internal class Canzone
    {
        public string Titolo;
        public string Autore;

        public Canzone(string Titolo, string Autore)
        {
            this.Titolo = Titolo;
            this.Autore = Autore;
        }
    }

}
