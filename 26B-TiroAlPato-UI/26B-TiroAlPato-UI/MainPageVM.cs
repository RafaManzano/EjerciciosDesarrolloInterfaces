using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml.Input;

namespace putopato
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
            conn = new HubConnection("https://patorafa.azurewebsites.net/");
            proxy = conn.CreateHubProxy("HubPato");
            conn.Start();
            tuPuntuacion = 0;
            puntuacionRival = 0;


            proxy.On("sumarRival", sumarRival);
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


        private async void sumarRival()
        {
            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
            () => {
                puntuacionRival++;
                NotifyPropertyChanged("PuntuacionRival");
            }
            );

        }


        public void ImagenPato_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tuPuntuacion++;
            proxy.Invoke("click");
            NotifyPropertyChanged("TuPuntuacion");
        }
        #endregion
    }
}
