using _15_BindingVM_Ejercicio3_Entities;
using _15_BindingVM_Ejercicio3_UI.Models.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _15_BindingVM_Ejercicio3_UI.ViewModels
{
    public class clsMainPageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private clsPersona personaSeleccionada;
        private List<clsPersona> listadoPersona;

        public clsMainPageVM () {
            this.listadoPersona = clsListadosPersonas.listadoPersonas();
        }

        public clsPersona PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                this.personaSeleccionada = value;
                NotifyPropertyChanged();
            }
        }


        public List<clsPersona> ListadoPersona
        {
            get
            {
                return listadoPersona;
            }
           
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /*
         * No se puede porque probablemente tenemos que implementar la iNotify
        public clsPersona personaSeleccionada { get; set; }
        public List<clsPersona> listadoPersona { get; set; }
        */
    }
}
