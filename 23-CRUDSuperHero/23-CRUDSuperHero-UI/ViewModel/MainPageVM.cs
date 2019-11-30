using _23_CRUDSuperHero_BL.Lists;
using _23_CRUDSuperHero_ENTITIES;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CRUDSuperHero_UI.ViewModel
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private ObservableCollection<clsCompanhia> companhias;
        private ObservableCollection<clsSuperhero> superheroes;
        private clsCompanhia companhiaSeleccionada;
        private clsSuperhero superheroSeleccionado;
        private clsListadoCompanhiaBL clist = new clsListadoCompanhiaBL();

        public MainPageVM()
        {
            this.companhias = new ObservableCollection<clsCompanhia>(clist.listadoCompanhias());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<clsCompanhia> Companhias
        {
            get
            {
                return companhias;
            }
        }

        public ObservableCollection<clsSuperhero> Superheroes
        {
            get
            {
                return superheroes;
            }
        }

        public clsSuperhero SuperheroSeleecionado
        {
            get
            {
                return superheroSeleccionado;
            }

            set
            {
                superheroSeleccionado = value;
            }
        }

        public clsCompanhia CompanhiaSeleccionada
        {
            get
            {
                return companhiaSeleccionada;
            }

            set
            {
                companhiaSeleccionada = value;
            }
        }

    }
}
