using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace _26_TiroAlPato_UI.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Propiedades privadas
        private int tuPuntuacion;
        private int puntuacionRival;
        private HubConnection conn;
        private IHubProxy proxy;

        #endregion

        #region Constructores
        public ViewModel()
        {
            //TODO try Catch
            conn = new HubConnection("https://chatsignalrderafa.azurewebsites.net");
            proxy = conn.CreateHubProxy("PatoHub");
            conn.Start();
            

            //proxy.On<int, int>("broadcastMessage", tuPuntuacion, puntuacionRival);
        }
        #endregion

        #region Metodos
        private void enviarPuntuacion(int puntuacion)
        {
            tuPuntuacion = puntuacion;
           
            proxy.Invoke("recogerPuntuacion", tuPuntuacion);
            
            //puntuacionRival = j2;
            //listaMensajes.Add(mensaje);
        }
        #endregion

    }
}
