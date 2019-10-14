using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_GridUWP.Model
{
    public class clsPersona
    {
        //Fernando usa para la propiedad privada asi _nombre, pero yo usare minusculas y para los metodos
        //Mayusculas
        private string nombre;
        //private string primerApellido;
        //private string segundoApellido;
        //private DateTime fechaNacimiento;

            /// <summary>
            /// Constructor por defecto
            /// </summary>
        public clsPersona()
        {
            this.nombre = "Rafael";
            this.Apellidos = "Manzano Medina";
        }

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

        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
