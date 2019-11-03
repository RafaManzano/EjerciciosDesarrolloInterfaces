using _16_BuscaminasSoso.Models;
using _16_BuscaminasSoso.Utiles;
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

namespace _16_BuscaminasSoso
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /*
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Object> list = clsListados.listadoJuego();
            Button b = (Button)sender;
            Image myImage = GetTemplateChild(b.Name) as Image;

            int numero = clsListados.intercambiarLetraPorNumero(sender);
            if(list[numero].GetType().IsInstanceOfType(new clsBomba()))
            {
                myImage.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(
                        new clsBomba().Lugar);
                ContentDialog perdiste = new ContentDialog
                {
                    Title = "Has perdido la partida",
                    Content = "Lo siento mucho, pero has perdido",
                    CloseButtonText = "Vale"
                };

                ContentDialogResult result = await perdiste.ShowAsync();
            }
            else{
                myImage.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(
                       new clsFallo().Lugar);
            }
            
            */
        //}
    }
}
