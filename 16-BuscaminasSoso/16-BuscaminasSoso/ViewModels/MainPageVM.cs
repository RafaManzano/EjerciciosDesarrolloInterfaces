using _16_BuscaminasSoso.Models;
using _16_BuscaminasSoso.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace _16_BuscaminasSoso.ViewModels
{
    class MainPageVM
    {
        private List<clsCasilla> listado;
        private clsCasilla casillaSeleccionada;

        public MainPageVM()
        {
            listado = clsListados.listadoCasillas();
        }

        public List<clsCasilla> Listado
        {
            get
            {
                return listado;
            }
        }

        public clsCasilla CasillaSeleccionada
        {
            get
            {
                return casillaSeleccionada;
            }

            set
            {
                casillaSeleccionada = value;
                if(casillaSeleccionada.IsBomba == true)
                {
                    
                }
            }
        }
    }
}
