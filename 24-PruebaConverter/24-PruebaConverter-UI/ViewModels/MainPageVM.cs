using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_PruebaConverter_UI.ViewModels
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private DateTime fechaNacimiento;

        public MainPageVM()
        {
            fechaNacimiento = DateTime.Now;
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
                NotifyPropertyChanged("FechaNacimiento");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
