using _16_BuscaminasSoso.Models;
using _16_BuscaminasSoso.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace _16_BuscaminasSoso.ViewModels
{
    class MainPageVM : INotifyPropertyChanged
    {
        private List<clsCasilla> listado;
        private clsCasilla casillaSeleccionada;
        int contador = 0;

        public MainPageVM()
        {
            listado = clsListados.listadoCasillas();
        }

        public List<clsCasilla> Listado
        {
            get
            {
                return listado;
            }
        }

        public clsCasilla CasillaSeleccionada
        {
            get
            {
                return casillaSeleccionada;
            }

            set
            {
                casillaSeleccionada = value;
                //casillaSeleccionada.YaPulsada = true;
                if (casillaSeleccionada != null)
                {
                    casillaSeleccionada.YaPulsada = true;
                    comprobarCasilla();
                }
            }
        }

        public async void comprobarCasilla()
        {
            //casillaSeleccionada.YaPulsada = true;
            if (casillaSeleccionada.IsBomba)
                {
                    //casillaSeleccionada.YaPulsada = true;
                    //NotifyPropertyChanged("CasillaSeleccionada");


                    var dialog = new MessageDialog("Has perdido!!");
                    await dialog.ShowAsync();
                    resetear();
                }
                else
                {
                    casillaSeleccionada = CasillaSeleccionada;
                    //NotifyPropertyChanged("CasillaSeleccionada");
                    //casillaSeleccionada.YaPulsada = true;

                    contador++;


                    if (contador == 3)
                    {
                        var dialog = new MessageDialog("Has ganado!!");
                        await dialog.ShowAsync();
                        resetear();
                    }
                }  
        }

        public void resetear()
        {
            listado = clsListados.listadoCasillas();
            contador = 0;
            NotifyPropertyChanged("Listado");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
