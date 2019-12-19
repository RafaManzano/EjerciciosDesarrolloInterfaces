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
            //foto = new Uri("ms-appx:///Assets/StoreLogo.png");
        }

        public clsSuperheroeConFoto(Uri foto)
        {
            //foto = foto; 
        }

        public clsSuperheroeConFoto(int id, string nombre)
        {
            IDSuperheroe = id;
            NombreSuperheroe = nombre;
            //Foto = foto;
        }

        public Uri Foto
        {
            get
            {
                return new Uri("ms-appx:///Assets/" + IDSuperheroe + ".jpg");
            }
        }
    }
}
