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

namespace XamarinCrudPersonasUI.ModelViews
{
    public class EditarPersonaVM : INotifyPropertyChanged
    {
        
        private clsPersona personaModificada;
        private clsDepartamento departamento;
        private ObservableCollection<clsDepartamento> listadoDepartamento;
        public DelegateCommand EditarCommand { get; }

        #region Constructores
        public EditarPersonaVM()
        {
            personaModificada = new clsPersona();
            cargarListadoDepartamentos();
            EditarCommand = new DelegateCommand(Editar);
        }

        public EditarPersonaVM(clsPersona persona)
        {
            this.personaModificada = persona;
            cargarListadoDepartamentos();
            EditarCommand = new DelegateCommand(Editar);
        }
        #endregion

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Propiedades Publicas
        public clsPersona PersonaModificada
        {
            get
            {
                return personaModificada;
            }
            set
            {
                personaModificada = value;
                NotifyPropertyChanged("PersonaModificada");
            }
        }

        public clsDepartamento Departamento
        {
            get
            {
                return departamento;
            }
            set
            {
                departamento = value;
                NotifyPropertyChanged("Departamento");
            }
        }

        public ObservableCollection<clsDepartamento> ListadoDepartamento
        {
            get
            {
                return listadoDepartamento;
            }
        }
        #endregion

        #region Comandos
        private async void Editar()
        {
                var respuesta = await Application.Current.MainPage.DisplayAlert("Editar", "Estas seguro que quieres modificar la persona", "Si", "No");

                if (respuesta)
                {
                    clsManejadorasPersonasBL capaBL = new clsManejadorasPersonasBL();

                    try
                    {

                        if (await capaBL.actualizarPersona(personaModificada) ==1)
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
        /// Este metodo carga el listado de departamentos
        /// </summary>
        private async void cargarListadoDepartamentos()
        {
            clsManejadorasDepartamentosBL capaBL = new clsManejadorasDepartamentosBL();
            clsListadoDepartamentoBL listBL = new clsListadoDepartamentoBL();
            clsDepartamento departamentoAux = new clsDepartamento();
            bool encontrado = false;
            try
            {
                //departamentoAux = await capaBL.obtenerDepartamentoPorID(personaModificada.IDDepartamento);
                listadoDepartamento = new ObservableCollection<clsDepartamento>(await listBL.listadoDepartamentos());
                NotifyPropertyChanged("ListadoDepartamento");
                for (int i = 0; i < listadoDepartamento.Count && !encontrado; i++)
                {
                    if (personaModificada.IDDepartamento == listadoDepartamento[i].ID)
                    {
                        Departamento = listadoDepartamento[i];
                        personaModificada.IDDepartamento = Departamento.ID;
                        NotifyPropertyChanged("PersonaModificada");
                        encontrado = true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            NotifyPropertyChanged("Departamento");
        }
        #endregion

        #region Displays
        private async void displayConexion()
        {
            await Application.Current.MainPage.DisplayAlert("Alerta", "Error en la conexion", "Ya vale");
        }

        private async void displayFallo()
        {
            await Application.Current.MainPage.DisplayAlert("Alerta", "Hay algun error, no se pudo modificar la persona", "Vaya faena");
        }

        private async void displayExito()
        {
            await Application.Current.MainPage.DisplayAlert("Completado con exito", "Persona Modificada", "Perfecto");
        }
        #endregion

    }
}
