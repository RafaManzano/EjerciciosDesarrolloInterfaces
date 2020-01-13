using _28_Diferencias_UI.ViewModel;
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
using Windows.UI.Xaml.Shapes;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace _28_Diferencias_UI
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageVM vm { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            vm = (MainPageVM)this.DataContext;
        }

        private void Imagenes_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Ellipse elipse = (Ellipse)sender;
            switch (elipse.Name)
            {
                case "d1i":
                    if(elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d1d.Opacity = 100;
                        vm.Contador++;
                    }
                   
                    break;
                case "d1d":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d1i.Opacity = 100;
                        vm.Contador++;
                    }
                    break;

                case "d2i":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d2d.Opacity = 100;
                        vm.Contador++;
                    }
                    break;
                case "d2d":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d2i.Opacity = 100;
                        vm.Contador++;
                    }
                    break;

                case "d3i":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d3d.Opacity = 100;
                        vm.Contador++;
                    }
                    break;
                case "d3d":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d3i.Opacity = 100;
                        vm.Contador++;
                    }
                    break;

                case "d4i":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d4d.Opacity = 100;
                        vm.Contador++;
                    }
                    break;
                case "d4d":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d4i.Opacity = 100;
                        vm.Contador++;
                    }
                    break;

                case "d5i":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d5d.Opacity = 100;
                        vm.Contador++;
                    }
                    break;
                case "d5d":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d5i.Opacity = 100;
                        vm.Contador++;
                    }
                    break;

                case "d6i":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d6d.Opacity = 100;
                        vm.Contador++;
                    }
                    break;
                case "d6d":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d6i.Opacity = 100;
                        vm.Contador++;
                    }
                    break;

                case "d7i":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d7d.Opacity = 100;
                        vm.Contador++;
                    }
                    break;
                case "d7d":
                    if (elipse.Opacity == 0)
                    {
                        elipse.Opacity = 100;
                        d7i.Opacity = 100;
                        vm.Contador++;
                    }
                    break;
            }
        }
    }
}
