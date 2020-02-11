using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAnimaciones_ENTITIES
{
    public class clsCiudad
    {
        public clsCiudad()
        {
            IDCiudad = 0;
            NombreCiudad = "";
        }

        public clsCiudad(int iDCiudad, string nombreCiudad)
        {
            IDCiudad = iDCiudad;
            NombreCiudad = nombreCiudad;
        }

        public int IDCiudad { get; set; }
        public string NombreCiudad { get; set; }
    }
}
