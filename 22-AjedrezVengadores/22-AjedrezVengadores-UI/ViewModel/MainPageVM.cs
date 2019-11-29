using _22_AjedrezVengadores_ENTITIES;
using _22_AjedrezVengadores_UI.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_AjedrezVengadores_UI.ViewModel
{
    public class MainPageVM
    {
        private clsCasilla casillaSeleccionada;
        private List<clsCasilla> tablero;

        public MainPageVM()
        {
            this.casillaSeleccionada = null;
            this.tablero = clsUtilidades.crearTablero();
        }

        public List<clsCasilla> Tablero
        {
            get
            {
                return tablero;
            }

            set
            {
                tablero = value;
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
            }
        }
    }
}
