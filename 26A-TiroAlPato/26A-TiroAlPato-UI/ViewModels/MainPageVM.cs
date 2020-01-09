using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml.Input;

namespace _26A_TiroAlPato_UI.ViewModels
{
    public class MainPageVM : INotifyPropertyChanged
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
        public MainPageVM()
        {
            //TODO try Catch
            conn = new HubConnection("http://localhost:63274/");
            proxy = conn.CreateHubProxy("PatoHub");
            conn.Start();


            //proxy.On<int, int>("broadcastMessage", tuPuntuacion, puntuacionRival);
        }
        #endregion

        #region Metodos
        public int TuPuntuacion
        {
            get
            {
                return tuPuntuacion;
            }

            set
            {
                tuPuntuacion = value;
            }
        }

        public int PuntuacionRival
        {
            get
            {
                return puntuacionRival;
            }

            set
            {
                puntuacionRival = value;
            }
        }

        /*
        private void enviarPuntuacion(int puntuacion)
        {
            tuPuntuacion = puntuacion;
           
            proxy.Invoke("recogerPuntuacion", tuPuntuacion);
            
            //puntuacionRival = j2;
            //listaMensajes.Add(mensaje);
        }
        */

        public void ImagenPato_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tuPuntuacion++;
            proxy.Invoke("recogerPuntuacion", tuPuntuacion);
            //NotifyPropertyChanged("TuPuntuacion");
        }

        private async void puntuaciones(int puntuacionJ1, int puntuacionJ2)
        {
            await Windows.ApplicationModel.Core.CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                tuPuntuacion = puntuacionJ1;
                puntuacionRival = puntuacionJ2;
                NotifyPropertyChanged("TuPuntuacion");
                NotifyPropertyChanged("PuntuacionRival");
            });
        }
        
        #endregion
    
    }
}
