using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class clsPersona
    {
        //Fernando usa para la propiedad privada asi _nombre, pero yo usare minusculas y para los metodos
        //Mayusculas
        private string nombre;
        //private string primerApellido;
        //private string segundoApellido;
        //private DateTime fechaNacimiento;

        public string Nombre {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
