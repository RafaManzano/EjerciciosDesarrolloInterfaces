using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinCrudPersonasBL.Handlers;
using XamarinCrudPersonasBL.Lists;
using XamarinCrudPersonasENTITIES;
using XamarinCrudPersonasUI.Views;

namespace XamarinCrudPersonasUI.ModelViews
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private ObservableCollection<clsPersona> listadoPersonas;
        private clsPersona personaSeleccionada;
        private INavigation navigation;
        public DelegateCommand BorrarCommand { get; }
        public DelegateCommand AnhadirCommand { get; }
        public DelegateCommand EditarCommand { get; }
        public DelegateCommand DetallesCommand { get; }

        #region Constructores
        public MainPageVM()
        {
            try
            {
                cargarListados();
                NotifyPropertyChanged("ListadoPersonas");
            }
            catch (Exception)
            {
               errorConexion();
            }
            this.BorrarCommand = new DelegateCommand(Eliminar, () => personaSeleccionada != null);
            this.AnhadirCommand = new DelegateCommand(Anhadir);
            this.EditarCommand = new DelegateCommand(Editar, () => personaSeleccionada != null);
            this.DetallesCommand = new DelegateCommand(Detalles, () => personaSeleccionada != null);
            navigation = null;
        }

        public MainPageVM(INavigation navigation)
        {
            try
            {
                cargarListados();
                NotifyPropertyChanged("ListadoPersonas");
            }
            catch (Exception)
            {
                errorConexion();
            }
            this.BorrarCommand = new DelegateCommand(Eliminar, () => personaSeleccionada != null);
            this.AnhadirCommand = new DelegateCommand(Anhadir);
            this.EditarCommand = new DelegateCommand(Editar, () => personaSeleccionada != null);
            this.DetallesCommand = new DelegateCommand(Detalles, () => personaSeleccionada != null);
            this.navigation = navigation;
        }
        #endregion

        #region Propiedades Publicas
        public clsPersona PersonaSeleccionada
        {
            get
            {
                return this.personaSeleccionada;
            }
            set
            {
                if (personaSeleccionada != value)
                {
                    this.personaSeleccionada = value;
                    BorrarCommand.RaiseCanExecuteChanged();
                    AnhadirCommand.RaiseCanExecuteChanged();
                    EditarCommand.RaiseCanExecuteChanged();
                    DetallesCommand.RaiseCanExecuteChanged();
                    NotifyPropertyChanged("PersonaSeleccionada");
                }
            }
        }

        public ObservableCollection<clsPersona> ListadoPersonas
        {
            get
            {
                return this.listadoPersonas;
            }
            set 
            { 
                this.listadoPersonas = value;
                NotifyPropertyChanged("ListadoPersonas");
            }
        }

        public INavigation Navigation
        {
            get
            {
                return navigation;
            }
            set
            {
                navigation = value;
                NotifyPropertyChanged("Navigation");
            }
        }
        #endregion


        #region Comandos
        /// <summary>
        /// Con este metodo eliminamos una persona de la BBDDD.
        /// </summary>
        private async void Eliminar()
        {
            var respuesta = await Application.Current.MainPage.DisplayAlert("Eliminar", "Estas seguro que deseas eliminar esta persona?", "Si", "No");

            if (respuesta)
            {
                clsManejadorasPersonasBL capaBL = new clsManejadorasPersonasBL();
                try
                {
                    if (await capaBL.borrarPersona(this.personaSeleccionada.IDPersona) == 1)
                    {
                        cargarListados();
                        this.personaSeleccionada = null;
                        NotifyPropertyChanged("PersonaSeleccionada");
                    }

                }
                catch (Exception e)
                {
                    errorConexion();
                }
            }
        }

        /// <summary>
        /// Con este metodo navegamos hacia la pantalla de anhadirPersona
        /// </summary>
        private async void Anhadir()
        {
            //clsManejadorasPersonasBL capaBL = new clsManejadorasPersonasBL();
            await navigation.PushAsync(new AnhadirPersona());
        }

        /// <summary>
        /// Con este metodo navegamos hacia la pantalla de editarPersona
        /// </summary>
        private async void Editar()
        {
            //clsManejadorasPersonasBL capaBL = new clsManejadorasPersonasBL();
            await navigation.PushAsync(new EditarPersona(personaSeleccionada));
        }

        /// <summary>
        /// Con este metodo navegamos hacia la pantalla de detallesPersona
        /// </summary>
        private async void Detalles()
        {
            await navigation.PushAsync(new DetallesPersona(personaSeleccionada));
        }
        #endregion

        #region Listado Personas
        /// <summary>
        /// Comentario: Este método nos permite cargar el listado de personas.
        /// </summary>
        public async void cargarListados()
        {
            try
            {
                this.listadoPersonas = new ObservableCollection<clsPersona>(await new clsListadoPersonaBL().listadoPersonas());
                NotifyPropertyChanged("ListadoPersonas");
            }
            catch (Exception)
            {
                errorConexion();
            }
        }
        #endregion

        #region Errores
        /// <summary>
        /// Cuando pase algun tipo de error
        /// </summary>
        private async void errorConexion()
        {
            await Application.Current.MainPage.DisplayAlert(
                   "Alerta",
                   "Conexion fallida",
                   "Vale"
                   );
            return;
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
