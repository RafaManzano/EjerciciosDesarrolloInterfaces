using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinCrudPersonasUI.ModelViews;

namespace XamarinCrudPersonasUI
{
    public partial class MainPage : ContentPage
    {
        public MainPageVM viewModel { get; set; }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageVM(Navigation);
            viewModel = (MainPageVM)BindingContext;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.cargarListados(); ;
            viewModel.PersonaSeleccionada = null;
        }
    }
}
