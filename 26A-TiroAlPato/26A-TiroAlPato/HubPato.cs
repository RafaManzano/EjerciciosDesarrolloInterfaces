using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace _26A_TiroAlPato
{
    public class HubPato : Hub
    {
        private int puntuacionJ1;
        private int puntuacionJ2;
        private String j1;
        private string j2;
        public void EnviarPuntuaciones()
        {
            Clients.All.broadcastMessage(puntuacionJ1, puntuacionJ2);
        }

        public void recogerPuntuacion(int puntuacion)
        {
            if (Context.ConnectionId == j1)
            {
                puntuacionJ1 += puntuacion;
            }
            else
            {
                puntuacionJ2 += puntuacion;
            }

            EnviarPuntuaciones();
        }

        public void elegirJugador()
        {
            if (j1.Equals(""))
            {
                j1 = Context.ConnectionId;
            }
            else
            {
                j2 = Context.ConnectionId;
            }
        }
    }
}