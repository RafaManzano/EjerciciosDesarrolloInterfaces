using ExamenAnimaciones_BL.Lists;
using ExamenAnimaciones_ENTITIES;
using ExamenAnimaciones_UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAnimaciones_UI.ViewModels
{
    public class MainPageVM : INotifyPropertyChanged
    {
        #region Propiedades privadas
        private ObservableCollection<clsCiudadConPredicciones> listadoCiudades;
        private ObservableCollection<clsCiudadConPredicciones> listadoCiudadesFiltrada;
        private clsListadoCiudadesBL apiCiudades = new clsListadoCiudadesBL();
        private clsListadoPrediccionesBL apiPredicciones = new clsListadoPrediccionesBL();
        private clsCiudadConPredicciones ciudadConPredicciones;
        private String textoBuscado;
        private DelegateCommand recargarComando;
        #endregion

        #region Contructores
        public MainPageVM()
        {
            listadoCiudades = new ObservableCollection<clsCiudadConPredicciones>();
            listadoCiudadesFiltrada = new ObservableCollection<clsCiudadConPredicciones>();
            cargarCiudades();
            ciudadConPredicciones = new clsCiudadConPredicciones();
            recargarComando = new DelegateCommand(Recargar);
        }

        

        #endregion

        #region Propiedades publicas
        public ObservableCollection<clsCiudadConPredicciones> ListadoCiudades
        {
            get
            {
                return this.listadoCiudades;
            }
            set
            {
                this.listadoCiudades = value;
                NotifyPropertyChanged("ListadoCiudades");
            }
        }
        public ObservableCollection<clsCiudadConPredicciones> ListadoCiudadesFiltrada
        {
            get
            {
                return this.listadoCiudadesFiltrada;
            }
            set
            {
                this.listadoCiudadesFiltrada = value;
                NotifyPropertyChanged("ListadoCiudadesFiltrada");
            }
        }

        public clsCiudadConPredicciones CiudadConPredicciones
        {
            get
            {
                return this.ciudadConPredicciones;
            }
            set
            {
                this.ciudadConPredicciones = value;
                cargarPredicciones(ciudadConPredicciones.IDCiudad);
                
            }
        }

        public DelegateCommand RecargarComando
        {
            get
            {
                return recargarComando;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Con este metodo cargamos la lista de ciudades
        /// </summary>
        /// <returns>Devolvemos el ObservableCollection del listado de ciudades</returns>
        private async void cargarCiudades()
        {
            Task<List<clsCiudad>> listCiudades = apiCiudades.listadoCiudades();
            List<clsCiudad> list = await listCiudades;

            for(int i = 0; i < list.Count; i++)
            { 
                this.listadoCiudades.Add(new clsCiudadConPredicciones(new clsCiudad(list[i].IDCiudad, list[i].NombreCiudad)));
                this.listadoCiudadesFiltrada.Add(new clsCiudadConPredicciones(new clsCiudad(list[i].IDCiudad, list[i].NombreCiudad)));
            }
            //NotifyPropertyChanged("ListadoCiudades");
        }

        /// <summary>
        /// Con este metodo cargamos las predicciones de esa ciudad pasada por parametro
        /// </summary>
        /// <param name="idCiudad">El id de la ciudad</param>
        private async void cargarPredicciones(int idCiudad)
        {
            this.ciudadConPredicciones.Predicciones = new List<clsPrediccion>();
            Task<List<clsPrediccion>> listPrediccion = apiPredicciones.listadoPredicciones(idCiudad);
            List<clsPrediccion> listado = await listPrediccion;
            for(int i = 0; i < listado.Count; i++)
            {
                listado[i].pronostico = "/Assets/" + listado[i].pronostico + ".png";
            }
            this.ciudadConPredicciones.Predicciones = listado;
            NotifyPropertyChanged("CiudadConPredicciones");
        }

        public void Filtrar()
        {
            if (String.IsNullOrWhiteSpace(TextoBuscado))
            {
                ListadoCiudadesFiltrada = ListadoCiudades;
                NotifyPropertyChanged("ListadoCiudadesFiltrada");
            }
            else
            {
                ObservableCollection<clsCiudadConPredicciones> list = new ObservableCollection<clsCiudadConPredicciones>(ListadoCiudades.ToList().FindAll(a => a.NombreCiudad.Contains(TextoBuscado)).ToList<clsCiudadConPredicciones>());
                //ListadoPersonaFiltrada = ListadoPersonaFiltrada.ToList().FindAll(a => a.Nombre.Contains(TextoBuscado));
                ListadoCiudadesFiltrada = list;
            }
        }

        private void Recargar()
        {
           this.listadoCiudadesFiltrada = this.listadoCiudades;
            NotifyPropertyChanged("ListadoCiudadesFiltrada");
        }

        public String TextoBuscado
             {
             get
             {
                return textoBuscado;
             }

            set
            {
                this.textoBuscado = value;
                Filtrar();
            }
        }
        #endregion

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
