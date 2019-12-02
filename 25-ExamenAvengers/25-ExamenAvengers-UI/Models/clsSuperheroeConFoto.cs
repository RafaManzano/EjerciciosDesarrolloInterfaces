using _25_ExamenAvengers_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_ExamenAvengers_UI.Models
{
    public class clsSuperheroeConFoto : clsSuperheroe
    {
        public clsSuperheroeConFoto()
        {
            Foto = new Uri("ms-appx:///Assets/StoreLogo.png");
        }

        public clsSuperheroeConFoto(Uri foto)
        {
            Foto = foto; 
        }

        public clsSuperheroeConFoto(int id, string nombre, Uri foto)
        {
            IDSuperheroe = id;
            NombreSuperheroe = nombre;
            Foto = foto;
        }

        public Uri Foto { get; set; }
    }
}
