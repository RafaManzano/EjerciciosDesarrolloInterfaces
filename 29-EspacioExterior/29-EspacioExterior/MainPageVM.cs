using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace _29_EspacioExterior
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private double posicionX;
        private double velocidad;

        public event PropertyChangedEventHandler PropertyChanged;
       

        private DispatcherTimer dispatcherTimer { get; set; }
        private bool moviendoX { get; set; }

        public MainPageVM()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            dispatcherTimer.Tick += timerTick;
            moviendoX = false;
            posicionX = 600.0;
            
        }

        private void timerTick(object sender, object e)
        {
            move();
        }

        public void move()
        {
            Double posicionFutura = 0.0;

            if(moviendoX)
            {
                posicionFutura = posicionX + velocidad;
                if (posicionFutura > 0 && posicionFutura < 1200)
                {
                    posicionX += velocidad;
                }
            }
            NotifyPropertyChanged("PosicionX");

        }

        public void derecha()
        {
            if (posicionX < 1200)
            {
                velocidad = 10;
            }
            else
            {
               velocidad = 0;
            }

        }
        /// <summary>
        /// Método que se encarga de mover la barra hacia arriba
        /// </summary>
        public void izquierda()
        {
            //_velocidad = -10;

            if (posicionX > 0 && posicionX - 10 > 0)
            {
                velocidad = -10;
            }
            else
            {
                velocidad = 0;
            }

        }

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Double PosicionX
        {
            get
            {
                return posicionX;
            }
            set
            {
                posicionX = value;
            }
        }

        public void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Right)
            {
                derecha();
                dispatcherTimer.Start();
                moviendoX = true;
            }

            if (e.Key == VirtualKey.Left)
            {
                izquierda();
                dispatcherTimer.Start();
                moviendoX = true;
              
            }

        }
        
        public void Grid_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Left || e.Key == VirtualKey.Right)
            {
                dispatcherTimer.Stop();
                moviendoX = false;
            }
        }

    }
}
