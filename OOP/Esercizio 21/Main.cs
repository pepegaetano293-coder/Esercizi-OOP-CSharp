using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_21
{
    internal class Storage
    {
        static void Main_Storage(string[] args)
        {
            // Esercizio 21 Storage
            // Il problema: Un'app deve poter salvare i documenti dell'utente o su un File locale o su un Database Cloud.

            // Interfaccia IStorage:
            //Metodo void SalvaDati(string dati).

            // Classi Concrete:
            // FileStorage: Stampa "Scrittura dati nel file 'documento.txt': [dati]".
            // CloudStorage: Stampa "Invio dati al server AWS in corso: [dati]".

            // Classe EditorDiTesto:
            // Proprietà Contenuto(string).
            //Metodo EseguiSalvataggio(IStorage supporto): Chiama il metodo di salvataggio del supporto passato.

            EditorDiTesto mioEditor = new EditorDiTesto("File segreti dello Stato Italiano");
            IStorage File = new FileStorage();
            IStorage File2 = new CloudStorage();

            mioEditor.EseguiSalvataggio(File);
            mioEditor.EseguiSalvataggio(File2);
        }
    }
}
