using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinCrudPersonasBL.Lists;
using XamarinCrudPersonasENTITIES;
using XamarinCrudPersonasUI.Views;

namespace XamarinCrudPersonasUI.ModelViews
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private ObservableCollection<clsPersona> personas;
        private clsListadoPersonaBL clist = new clsListadoPersonaBL();
        private INavigation navigate;

        #region Constructores
        public MainPageVM()
        {
            cargarListado();
            AnhadirCommand = new DelegateCommand(VistaAnhadir);
            navigate = null;

        }

        public MainPageVM(INavigation navigation)
        {
            cargarListado();
            AnhadirCommand = new DelegateCommand(VistaAnhadir);
            navigate = navigation;

        }
        #endregion



        public ObservableCollection<clsPersona> Personas
        {
            get
            {
                return personas;
            }

            set
            {
                personas = value;
            }
        }

        public INavigation Navigate
        {
            get
            {
                return navigate;
            }
            set
            {
                navigate = value;
                NotifyPropertyChanged("Navigate");
            }
        }

        #region NotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        private async void cargarListado()
        {
            Task<List<clsPersona>> l = clist.listadoPersonas();
            List<clsPersona> list = await l;
            this.personas = new ObservableCollection<clsPersona>(list);
            NotifyPropertyChanged("Personas");
        }

        #region DelegateCommand
        public DelegateCommand AnhadirCommand { get; }
        #endregion

        #region Metodos para commands
        private async void VistaAnhadir()
        {
            await navigate.PushAsync(new XamarinCrudPersonasUI.Views.AnhadirPersona());
        }
        #endregion
    }
}
