using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_ExamenAvengers_ENTITIES
{
    public class clsMisiones
    {
        public clsMisiones()
        {
            IDMision = 0;
            TituloMision = "Vacio";
            DescripcionMision = "Nada";
            Reservada = 0;
            IDSuperheroe = 0;
            Observaciones = "Nada";
        }

        public clsMisiones(int id, string titulo, string descripcion, int reservada, int idsuperhero, string observaciones)
        {
            IDMision = id;
            TituloMision = titulo;
            DescripcionMision = descripcion;
            Reservada = reservada;
            IDSuperheroe = idsuperhero;
            Observaciones = observaciones;
        }


        public int IDMision { get; set; }
        public string TituloMision { get; set; }
        public string DescripcionMision { get; set; }
        public int Reservada { get; set; }
        public int IDSuperheroe { get; set; }
        public string Observaciones { get; set; }
    }
}
