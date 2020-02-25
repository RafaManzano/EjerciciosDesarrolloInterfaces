using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using XamarinCrudPersonasBL.Lists;
using XamarinCrudPersonasENTITIES;

namespace XamarinCrudPersonasUI.ModelViews
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private ObservableCollection<clsPersona> personas;
        private clsListadoPersonaBL clist = new clsListadoPersonaBL();

        public MainPageVM()
        {
            cargarListado();

        }

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async void cargarListado()
        {
            Task<List<clsPersona>> l = clist.listadoPersonas();
            List<clsPersona> list = await l;
            this.personas = new ObservableCollection<clsPersona>(list);
            NotifyPropertyChanged("Personas");



        }
    }
}
