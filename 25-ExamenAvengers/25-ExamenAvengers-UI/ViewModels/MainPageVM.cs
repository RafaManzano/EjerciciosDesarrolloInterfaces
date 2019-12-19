using _25_ExamenAvengers_BL.Handlers;
using _25_ExamenAvengers_BL.Lists;
using _25_ExamenAvengers_ENTITIES;
using _25_ExamenAvengers_UI.Models;
using _25_ExamenAvengers_UI.Utiles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Input;

namespace _25_ExamenAvengers_UI.ViewModels
{
    public class MainPageVM : INotifyPropertyChanged
    {
        #region Propiedades Privadas
        private ObservableCollection<clsSuperheroeConFoto> superheroes;
        private ObservableCollection<clsMisiones> misiones;
        private clsSuperheroe superheroeSeleccionado;
        private clsMisiones misionSeleccionada;

        //Con esta llamada a la BBDD tenemos todos los superheroes para poder anhadirle la foto
        private clsListadosSuperheroeBL slist = new clsListadosSuperheroeBL();
        private List<clsSuperheroe> listadoSuperheroes;

        private clsListadosMisionesBL mlist = new clsListadosMisionesBL();
        private clsManejadorasBL manmision = new clsManejadorasBL();
        #endregion

        #region Constructor
        public MainPageVM()
        {
            //TODO Try Catch
            listadoSuperheroes = slist.listadoSuperheroes();
            superheroes = new ObservableCollection<clsSuperheroeConFoto>(clsUtiles.listadoSuperheroesConFoto(listadoSuperheroes));
            misiones = new ObservableCollection<clsMisiones>(mlist.listadoMisionesDisponibles());
        }
        #endregion

        #region Get y Set
        public ObservableCollection<clsSuperheroeConFoto> Superheroes
        {
            get
            {
                return superheroes;
            }
        }

        public clsSuperheroe SuperheroSeleccionado
        {
            get
            {
                return superheroeSeleccionado;
            }

            set
            {
                superheroeSeleccionado = value;
                NotifyPropertyChanged("SuperheroSeleccionado");
                
            }
        }

        public ObservableCollection<clsMisiones> Misiones
        {
            get
            {
                return misiones;
            }
        }

        public clsMisiones MisionSeleccionada
        {
            get
            {
                return misionSeleccionada;
            }

            set
            {
                misionSeleccionada = value;
                NotifyPropertyChanged("MisionSeleccionada");

            }
        }
        #endregion

        #region PropertyChangedEventHandler
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Tapped para el boton
        /// <summary>
        /// Para la pulsacion del boton desde el viewModel, aqui se actualizara la mision
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Reservar_Tapped(object sender, TappedRoutedEventArgs e)
        { 
            if (misionSeleccionada != null)
            {
                misionSeleccionada.Reservada = 1;
                misionSeleccionada.IDSuperheroe = superheroeSeleccionado.IDSuperheroe;
                manmision.actualizarMision(misionSeleccionada);
                misiones = new ObservableCollection<clsMisiones>(mlist.listadoMisionesDisponibles());
                NotifyPropertyChanged("Misiones");

            }
                
        }
        #endregion
    }
}
