using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace _26B_TiroAlPatoServer
{
    public class HubPato : Hub
    {
        public async Task click()
        {
            Clients.Others.sumarRival();
        }
        /*
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
        */

        public override Task OnConnected()
        {
           return base.OnConnected();
        }
    }
}