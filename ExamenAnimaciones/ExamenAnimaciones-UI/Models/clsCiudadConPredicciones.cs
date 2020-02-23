using ExamenAnimaciones_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAnimaciones_UI.Models
{
    public class clsCiudadConPredicciones : clsCiudad
    {
        public clsCiudadConPredicciones()
        {
            IDCiudad = 0;
            NombreCiudad = "";
            Predicciones = new List<clsPrediccion>();
        }

        public clsCiudadConPredicciones(clsCiudad ciudad)
        {
            this.IDCiudad = ciudad.IDCiudad;
            this.NombreCiudad = ciudad.NombreCiudad;
           
        }

        public clsCiudadConPredicciones(List<clsPrediccion> predicciones)
        {
            this.Predicciones = predicciones;
        }
        public List<clsPrediccion> Predicciones { get; set; }
    }
}
