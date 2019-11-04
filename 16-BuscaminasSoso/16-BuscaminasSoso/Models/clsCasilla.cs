using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _16_BuscaminasSoso.Models
{
    class clsCasilla : INotifyPropertyChanged
    {
        private Uri imagen;
        private Boolean isBomba;
        private Boolean yaPulsada;
        public clsCasilla()
        {
            imagen = new Uri("ms-appx:///Assets/cda.png");
            IsBomba = false;
        }

        public Uri Imagen {
            get
            {
                voltearCarta();
                return imagen;
            }
        }
        public Boolean IsBomba {
            get {
                //voltearCarta();
                //NotifyPropertyChanged("Imagen");
                return isBomba; 
            }
            set
            {
                isBomba = IsBomba;
            }
        }
        public Boolean YaPulsada
        {
            get
            {
                //NotifyPropertyChanged();
                return yaPulsada;
            }
            set
            {
                yaPulsada = YaPulsada;
            }
        }

        public void voltearCarta()
        {
            if (YaPulsada == true)
            {
                if (IsBomba == true)
                {
                    imagen = new Uri("ms-appx:///Assets/bombazo.png");
                    //NotifyPropertyChanged("Imagen");
                }
                else
                {
                    imagen = new Uri("ms-appx:///Assets/aguazo.png");
                }
            }
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
