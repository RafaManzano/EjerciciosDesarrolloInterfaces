using _19_CRUDPersonasCompletoUWP_BL.Lists;
using _19_CRUDPersonasCompletoUWP_Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace _19_CRUDPersonasCompletoUWP_UI.ModelViews
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private clsPersona personaSeleccionada;
        private ObservableCollection<clsPersona> listadoPersonaCompleta;
        private DelegateCommand eliminarComando;
        private DelegateCommand filtrarComando;
        private DelegateCommand newCommand;
        private DelegateCommand recargarComando;
        private DelegateCommand guardarComando;
        private ObservableCollection<clsPersona> listadoPersonaFiltrada;
        private String textoBuscado;
        private ObservableCollection<clsDepartamento> dpto;
        private clsListadoPersonasBL bbdd = new clsListadoPersonasBL();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainPageVM()
        {
            this.listadoPersonaCompleta = new ObservableCollection<clsPersona>(bbdd.listadoPersonas());
            this.listadoPersonaFiltrada = this.listadoPersonaCompleta;
            eliminarComando = new DelegateCommand(Eliminar, () => personaSeleccionada != null);
            filtrarComando = new DelegateCommand(Filtrar, () => !String.IsNullOrEmpty(textoBuscado));
            recargarComando = new DelegateCommand(Recargar);
            newCommand = new DelegateCommand(Nuevo);
            guardarComando = new DelegateCommand(Guardar, () => personaSeleccionada != null);
            this.dpto = new ObservableCollection<clsDepartamento>(bbdd.listadoDepartamentos());
        }

        public clsPersona PersonaSeleccionada
        {
            get
            {
                //eliminarComando.CanExecute(personaSeleccionada != null);
                return personaSeleccionada;
            }
            set
            {
                this.personaSeleccionada = value;
                eliminarComando.RaiseCanExecuteChanged();
                eliminarComando.CanExecute(personaSeleccionada);
                guardarComando.RaiseCanExecuteChanged();
                guardarComando.CanExecute(personaSeleccionada);
                NotifyPropertyChanged("PersonaSeleccionada");
                
            }
        }


        public ObservableCollection<clsPersona> ListadoPersonaCompleta
        {
            get
            {
                //return listadoPersonaCompleta;
                return listadoPersonaCompleta = new ObservableCollection<clsPersona>(bbdd.listadoPersonas());
            }
            set
            {
                listadoPersonaCompleta = value;
            }

        }


        public DelegateCommand EliminarComando
        {
            get
            {
                return eliminarComando;
            }
        }

        public DelegateCommand FiltrarComando
        {
            get
            {
                return filtrarComando;
            }
        }


        public async void Eliminar()
        {
            ContentDialog subscribeDialog = new ContentDialog
            {
                Title = "¿Estas seguro que quiere eliminar?",
                PrimaryButtonText = "Aceptar",
                SecondaryButtonText = "Cancelar",
                DefaultButton = ContentDialogButton.Secondary
            };

            ContentDialogResult result = await subscribeDialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                //No estoy seguro, pero o llamamos de nuevo a la BBDD o se lo borramos a los dos
                //listadoPersonaFiltrada.Remove(personaSeleccionada);
                bbdd.borrarPersona(personaSeleccionada.IDPersona);
                //NotifyPropertyChanged("ListadoPersonaCompleta");
                listadoPersonaFiltrada = new ObservableCollection<clsPersona>(bbdd.listadoPersonas());
                NotifyPropertyChanged("ListadoPersonaFiltrada");
            }
        }

        public void Filtrar()
        {
            if (String.IsNullOrWhiteSpace(TextoBuscado))
            {
                ListadoPersonaFiltrada = ListadoPersonaCompleta;
                NotifyPropertyChanged("ListadoPersonaFiltrada");
            }
            else
            {
                ObservableCollection<clsPersona> list = new ObservableCollection<clsPersona>(ListadoPersonaCompleta.ToList().FindAll(a => a.Nombre.Contains(TextoBuscado)).ToList<clsPersona>());
                //ListadoPersonaFiltrada = ListadoPersonaFiltrada.ToList().FindAll(a => a.Nombre.Contains(TextoBuscado));
                ListadoPersonaFiltrada = list;
        }
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
                filtrarComando.Execute(null);
                filtrarComando.RaiseCanExecuteChanged();
                NotifyPropertyChanged("ListadoPersonaFiltrada");
            }
        }

        public ObservableCollection<clsPersona> ListadoPersonaFiltrada
        {
            get
            {
                return listadoPersonaFiltrada;
            }
            set
            {
                listadoPersonaFiltrada = value;
            }

        }

        public DelegateCommand NewCommand
        {
            get
            {
                return newCommand;
            }
        }

        public void Nuevo()
        {
            personaSeleccionada = new clsPersona();
            NotifyPropertyChanged("PersonaSeleccionada");
        }

        public DelegateCommand RecargarCommand
        {
            get
            {
                return recargarComando;
            }
        }

        public void Recargar()
        {
            ListadoPersonaFiltrada = ListadoPersonaCompleta;
            NotifyPropertyChanged("ListadoPersonaFiltrada");
        }

        public DelegateCommand GuardarComando
        {
            get
            {
                return guardarComando;
            }
        }

        public async void Guardar()
        {
            if(bbdd.estoyEnBBDD(personaSeleccionada))
            {
                ContentDialog subscribeDialog = new ContentDialog
                {
                    Title = "Actualizado correctamente en la BBDD",
                    PrimaryButtonText = "Perfecto",
                    DefaultButton = ContentDialogButton.Primary
                };
                ContentDialogResult result = await subscribeDialog.ShowAsync();
                bbdd.actualizarPersona(personaSeleccionada);
            }
            else
            {
                bbdd.crearPersona(personaSeleccionada);
                ContentDialog subscribeDialog = new ContentDialog
                {
                    Title = "Creado correctamente en la BBDD",
                    PrimaryButtonText = "Perfecto",
                    DefaultButton = ContentDialogButton.Primary
                };
                ContentDialogResult result = await subscribeDialog.ShowAsync();
            }
        }

        public ObservableCollection<clsDepartamento> ListadoDepartamentos
        {
            get
            {
                return dpto;
            }
            set
            {
                dpto = value;
            }

        }
    }
}
