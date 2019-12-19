using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace _26_TiroAlPato_UI
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            Random rnd = new Random();
            this.InitializeComponent();

            //desaparecerPato.Begin();
            
            animacionEjeX.From = rnd.Next(1000);
            animacionEjeY.From = rnd.Next(1000);
            //desaparecerPato.Children.ElementAt(0).SetValue(rnd.Next(1000));
            desaparecerPato.Begin();


        }

        private void AnimacionEjeY_Completed(object sender, object e)
        {
            Random rnd = new Random();
            animacionEjeX.From = rnd.Next(1500);
            animacionEjeY.From = rnd.Next(700);
            animacionEjeX.To = rnd.Next(1500);
            animacionEjeY.To = rnd.Next(700);
            //desaparecerPato.Children.ElementAt(0).SetValue(rnd.Next(1000));
            desaparecerPato.Begin();
        }

        private void ImagenPato_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Puntuacion +1
        }
    }
}
