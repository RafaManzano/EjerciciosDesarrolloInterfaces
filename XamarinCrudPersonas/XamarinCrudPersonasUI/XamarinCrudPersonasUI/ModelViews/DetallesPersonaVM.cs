using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinCrudPersonasBL.Handlers;
using XamarinCrudPersonasENTITIES;

namespace XamarinCrudPersonasUI.ModelViews
{
    public class DetallesPersonaVM : INotifyPropertyChanged
    {
        private clsPersona personaDetalle;
        private clsDepartamento departamento;

        #region Constructores
        public DetallesPersonaVM()
        {
            personaDetalle = new clsPersona();
            departamento = new clsDepartamento();
        }

        public DetallesPersonaVM(clsPersona persona)
        {
            personaDetalle = persona;
            obtenerDepartamentoPersonaDetalle();
        }
        #endregion

        #region Propiedades Publicas
        public clsPersona PersonaDetalle
        {
            get
            {
                return personaDetalle;
            }
        }

        public clsDepartamento Departamento
        {
            get
            {
                return departamento;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Este metodo obtiene el departamento del id de la persona
        /// </summary>
        private async void obtenerDepartamentoPersonaDetalle()
        {
            try
            {
                departamento = await new clsManejadorasDepartamentosBL().obtenerDepartamentoPorID(personaDetalle.IDDepartamento);
                NotifyPropertyChanged("Departamento");
            }
            catch (Exception)
            {
                displayConexion();
            }

        }
        #endregion

        #region Mensajes
        private async void displayConexion()
        {
            await Application.Current.MainPage.DisplayAlert("Alerta", "Error en la conexión", "Vale");
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
