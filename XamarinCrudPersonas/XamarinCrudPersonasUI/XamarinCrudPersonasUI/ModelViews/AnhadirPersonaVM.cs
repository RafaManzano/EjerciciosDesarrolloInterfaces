using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinCrudPersonasBL.Handlers;
using XamarinCrudPersonasBL.Lists;
using XamarinCrudPersonasENTITIES;

namespace XamarinCrudPersonasUI.ModelViews
{
    public class AnhadirPersonaVM : INotifyPropertyChanged
    {
        private clsPersona personaAnhadida;
        private ObservableCollection<clsDepartamento> listadoDepartamentos;
        private clsDepartamento departamentoSeleccionado;
        public DelegateCommand GuardarCommand { get; }

        #region Constructor
        public AnhadirPersonaVM()
        {
            personaAnhadida = new clsPersona();
            this.GuardarCommand = new DelegateCommand(Insertar);
            cargarListadoDepartamentos();
        }
        #endregion

        #region Propiedades Publicas
        public clsPersona PersonaAnhadida
        {
            get
            {
                return personaAnhadida;
            }
            set
            {
                personaAnhadida = value;
                NotifyPropertyChanged("PersonaAnhadida");
            }
        }

        public ObservableCollection<clsDepartamento> ListadoDepartamentos
        {
            get
            {
                return listadoDepartamentos;
            }
            
        }

        public clsDepartamento DepartamentoSeleccionado
        {
            get
            {
                return departamentoSeleccionado;
            }
            set
            {
                departamentoSeleccionado = value;
                NotifyPropertyChanged("DepartamentoSeleccionado");
            }
        }
        #endregion

        #region Comandos
        /// <summary>
        /// Este metodo inserta una persona en la BBDD 
        /// </summary>
        private async void Insertar()
        {
            var respuesta = await Application.Current.MainPage.DisplayAlert("Insertar", "Quieres insertar esta persona?", "Si", "No");

            if (respuesta)
            {
                clsManejadorasPersonasBL capaBL = new clsManejadorasPersonasBL();
                try
                {
                    PersonaAnhadida.IDDepartamento = DepartamentoSeleccionado.ID;
                    if (await capaBL.crearPersona(personaAnhadida) == 1)
                    {
                        displayExito();
                    }
                    else
                    {
                        displayFallo();
                    }

                }
                catch (Exception)
                {
                    displayConexion();
                }

            }

        }
        #endregion

        #region Listados
        /// <summary>
        /// Este metodo carga la lista de departamentos de la BBDD
        /// </summary>
        private async void cargarListadoDepartamentos()
        {
            try
            {
                listadoDepartamentos = new ObservableCollection<clsDepartamento>(await new clsListadoDepartamentoBL().listadoDepartamentos());
                NotifyPropertyChanged("ListadoDepartamentos");
            }
            catch (Exception)
            {
                displayConexion();
            }
        }
        #endregion

        #region Displays
        private async void displayConexion()
        {
            await Application.Current.MainPage.DisplayAlert("Alerta", "Error en la conexion", "Ya vale");
        }

        private async void displayFallo()
        {
            await Application.Current.MainPage.DisplayAlert("Alerta", "Hay algun error, no se pudo insertar la persona", "Vaya faena");
        }

        private async void displayExito()
        {
            await Application.Current.MainPage.DisplayAlert("Completado con exito", "Persona Insertada", "Perfecto");
        }
        #endregion

        #region NotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
