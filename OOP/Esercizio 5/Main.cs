using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Playlist
{
    class Playlist_Esercizio
    {
        static void MainPlaylist(string[] args)
        {
            // Esercizio 5. Relazione tra oggetti
            // (1) Crea una classe "Canzoni", con proprietà "Titolo" e "Autore" e Costruttore completo.
            // (2) Crea una classe "Playlist":
            // (2.1) Campo privato: List<Canzone> _canzoni.
            // (2.2) Proprietà: NomePlaylist.
            // (2.3) Costruttore: Inizializza la lista vuota e assegna il nome alla playlist.
            // (3) Metodo: AggiungiCanzone(Canzone c): Aggiunge la canzone alla lista interna.
            // (4) Metodo MostraPlaylist(): Stampa il nome della playlist e tutti i titoli delle canzoni presenti.

            // (5) Nel Main: Crea 3 oggetti Canzone. Crea un oggetto Playlist. Aggiungi le canzoni alla playlist e invoca MostraPlaylist().

            Canzone canzone1 = new Canzone("Faint", "Linkin Park");
            Canzone canzone2 = new Canzone("Maledetta Primavera", "Loretta Goggi");
            Canzone canzone3 = new Canzone("Una magia", "Anthony");

            Playlist miaplaylist = new Playlist("I miei preferiti");

            miaplaylist.AggiungiCanzone(canzone1);
            miaplaylist.AggiungiCanzone(canzone2);
            miaplaylist.AggiungiCanzone(canzone3);
            miaplaylist.MostraPlaylist();

            

        }
    }
}
