using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAnimaciones_ENTITIES
{
    public class clsPrediccion
    {
        public int idCiudad { get; set; }
        public DateTime fecha { get; set; }
        public Double temperaturaMaxima { get; set; }
        public Double temperaturaMinima { get; set; }
       
        public Double humedad { get; set; }
        public string pronostico { get; set; }
    }
}
