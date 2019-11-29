using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CRUDSuperHero_ENTITIES
{
    public class clsSuperhero
    {
        public clsSuperhero()
        {
            ID = 0;
            Nombre = "";
            Apellidos = "";
            Apodo = "";
            Sexo = "";
            IDCompanhia = 0;
            Foto = new byte[1];
        }

        public clsSuperhero(int id, string nombre, string apellidos, string apodo, String sexo, int idCompanhia, Byte[] foto)
        {
            ID = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Apodo = apodo;
            Sexo = sexo;
            IDCompanhia = idCompanhia;
            Foto = foto;
        }

        public int ID { get; set; }
        public String Nombre { get; set; }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
        public String Apellidos { get; set; }
        public String Apodo { get; set; }
        public String Sexo { get; set; }
        public int IDCompanhia { get; set; }
        public Byte[] Foto { get; set; }
    }
}
