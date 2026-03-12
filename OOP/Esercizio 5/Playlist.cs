using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Playlist
{
    internal class Playlist
    {
        private List<Canzone> _canzoni;
        public string NomePlaylist;

        public Playlist(string NomePlaylist)
        {
            _canzoni = new List<Canzone>();
            this.NomePlaylist = NomePlaylist;
        }

        public void AggiungiCanzone(Canzone NuovaCanzone)
        {
            _canzoni.Add(NuovaCanzone);
        }
        public void MostraPlaylist()
        {
            Console.WriteLine($"Nome della playlist '{NomePlaylist}':");
            foreach(Canzone item in _canzoni)
            {
                Console.WriteLine($"-> {item.Autore} - {item.Titolo}");
            }
        }
    }

}
