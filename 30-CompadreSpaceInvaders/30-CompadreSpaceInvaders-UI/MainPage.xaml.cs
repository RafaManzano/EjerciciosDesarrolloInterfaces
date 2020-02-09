using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace _30_CompadreSpaceInvaders_UI
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


        private Ellipse crearEllipse()
        {
            Ellipse ellipse = new Ellipse();
            Random rnd = new Random();
            ellipse.Height = rnd.Next(20);
            ellipse.Width = rnd.Next(20);
            Canvas.SetLeft(ellipse, 1200);
            Canvas.SetTop(ellipse, rnd.Next(1000));
            ellipse.Stroke = new SolidColorBrush(Colors.Green);
            ellipse.Fill = new SolidColorBrush(Colors.Green);

            ellipse.RenderTransform = new TranslateTransform();
            return ellipse;

        }

        private void crearAnimacion(Ellipse ellipse)
        {
            Storyboard storyboard = new Storyboard();

            DoubleAnimation translateXAnimation = new DoubleAnimation();
            translateXAnimation.From = 1200;
            translateXAnimation.To = -20;
            translateXAnimation.Duration = new Duration(TimeSpan.FromSeconds((10 * 2) / ellipse.Height));

            Storyboard.SetTarget(translateXAnimation, ellipse);
            Storyboard.SetTargetProperty(translateXAnimation, "(UIElement.RenderTransform).(TranslateTransform.X)");

            storyboard.Children.Add(translateXAnimation);
            canvas.Children.Add(ellipse);
            translateXAnimation.Completed += TranslateXAnimation_Completed;
            storyboard.Begin();
        }

        private void TranslateXAnimation_Completed(object sender, object e)
        {
            crearAnimacion(crearEllipse());
        }
    }
}
