using System;
using System.Collections.Generic;
using System.Text;

namespace CorsoCSharp.OOP.Esercizio_15
{
    internal class GestoreAvvisi:INotificatore
    {
        public void EseguiNotifica(INotificatore Notificatore, string msg)
        {
            Notificatore.Invia(msg);
        }
    }
}
