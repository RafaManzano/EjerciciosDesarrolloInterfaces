using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace _29_EspacioExterior
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageVM viewModel { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            animacionEstrellasGordas.Begin();
            animacionEstrellasMedianas.Begin();
            animacionEstrellasPequenhas.Begin();
            viewModel = new MainPageVM();
            /*
            Ellipse e = new Ellipse();
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255, 0, 0, 128);
            e.Fill = mySolidColorBrush;
            e.Width = 30;
            e.Height = 30;
            canvas.Children.Add(e);
            */
        }

        private void allowfocus_Loaded(object sender, RoutedEventArgs e)
        {
            Window.Current.Content.KeyDown += this.viewModel.Grid_KeyDown;
            Window.Current.Content.KeyUp += this.viewModel.Grid_KeyUp;
        }
    }
}
