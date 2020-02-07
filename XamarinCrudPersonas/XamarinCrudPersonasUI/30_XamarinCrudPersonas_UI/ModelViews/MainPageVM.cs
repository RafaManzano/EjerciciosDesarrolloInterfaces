using _30_XamarinCrudPersonas_BL.Lists;
using _30_XamarinCrudPersonas_ENTITIES;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

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
            this.personas = new ObservableCollection<clsPersona>();
            Task<List<clsPersona>> l = clist.listadoPersonas();
            List<clsPersona> list = await l;
            NotifyPropertyChanged("Personas");



        }
    }

    
}
