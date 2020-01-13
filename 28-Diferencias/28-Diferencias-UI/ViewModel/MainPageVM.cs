using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Shapes;

namespace _28_Diferencias_UI.ViewModel
{
    public class MainPageVM : INotifyPropertyChanged
    {
        #region Propiedades Privadas
        private int contador;
        #endregion

        #region Constructor
        public MainPageVM()
        {
            contador = 0;
        }
        #endregion

        #region PropertyChangedEventHandler
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Get y Set

        public int Contador
        {
            get
            {
                return contador;
            }

            set
            {
                contador = value;
                NotifyPropertyChanged("Contador");
                if (contador == 7)
                {
                    FinalPartida();
                }
            }
        }
        #endregion

        #region Metodo para finalizar juego
        private async void FinalPartida()
        {
            ContentDialog finalPartida = new ContentDialog
            {
                Title = "Enhorabuena has completado el desafio",
                PrimaryButtonText = "Genial!"
            };

            ContentDialogResult result = await finalPartida.ShowAsync();
            #endregion


        }
    }
}
