using ExamenSorpresa_Halloween.Models;
using ExamenSorpresa_Halloween.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSorpresa_Halloween.ViewModels
{
    class clsMainPageVM : INotifyPropertyChanged
    {
        #region "Atributos privados"
        //Atributos privados
        private List<clsMarca> marcas;
        private List<clsModelo> modelos;
        //private List<clsMarcaModelo> MarcayModelos;
        private clsMarca marcaSeleccionada;
        private clsModelo modeloSeleccionado;
        private string seleccionCompleta;
        #endregion

        //Para notificar los cambios
        public event PropertyChangedEventHandler PropertyChanged;

        public clsMainPageVM()
        {
            this.marcas = clsListados.listadoMarcas();
            //this.MarcayModelos = clsListados.listadoMarcayModelos();
        }

        public List<clsMarca> Marcas
        {
            get
            {
                return marcas;
            }

        }

        public List<clsModelo> Modelos
        {
            get
            {
                return modelos;
            }

        }

        public clsMarca MarcaSeleccionada
        {
            get
            {
                return marcaSeleccionada;
            }
            
            set
            {
                this.marcaSeleccionada = value;
                this.modelos = clsListados.listadodeModeloPorMarca(clsListados.listadoModelos(), marcaSeleccionada.ID);
                NotifyPropertyChanged("Modelos");
            }
        }

        public clsModelo ModeloSeleccionado
        {
            get
            {
                return modeloSeleccionado;
            }

            set
            {
                this.modeloSeleccionado = value;
                //if (marcaSeleccionada != null && modeloSeleccionado != null)
                //{
                    //seleccionCompleta = marcaSeleccionada.Marca + " " + modeloSeleccionado.Modelo;
                //}
                NotifyPropertyChanged("SeleccionCompleta");
            }
        }

        public String SeleccionCompleta
        {
            get
            {
                if(marcaSeleccionada != null && modeloSeleccionado != null)
                {
                seleccionCompleta = marcaSeleccionada.Marca + " " + modeloSeleccionado.Modelo;
                //marcaSeleccionada.Marca = "";
                //modeloSeleccionado.Modelo = "";
                }
                
                return seleccionCompleta;
            }
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
