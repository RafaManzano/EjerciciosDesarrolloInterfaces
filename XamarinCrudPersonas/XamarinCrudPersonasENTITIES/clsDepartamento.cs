using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinCrudPersonasENTITIES
{
    public class clsDepartamento
    {
        public clsDepartamento()
        {

        }

        public clsDepartamento(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
    }
}
