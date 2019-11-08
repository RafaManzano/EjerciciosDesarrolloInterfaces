using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_EventoCommands.Models
{
    public class clsPersona
    {
        //Fernando usa para la propiedad privada asi _nombre, pero yo usare minusculas y para los metodos
        //Mayusculas
        private string nombre;
        //private string primerApellido;
        //private string segundoApellido;
        //private DateTime fechaNacimiento;

        public clsPersona()
        {
            nombre = "VACIO";
            PrimerApellido = "VACIO";
            SegundoApellido = "VACIO";
            FechaNacimiento = DateTime.Now;
        }

        public clsPersona(string nombre, string primerApellido, string segundoApellido, DateTime fecha)
        {
            this.nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fecha;
        }

        public string Nombre
        {
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
