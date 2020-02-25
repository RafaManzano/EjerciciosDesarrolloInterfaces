using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCrudPersonasENTITIES;
using XamarinCrudPersonasUI.ModelViews;

namespace XamarinCrudPersonasUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallesPersona : ContentPage
    {
        public DetallesPersona(clsPersona persona)
        {
            InitializeComponent();
            BindingContext = new DetallesPersonaVM(persona);
        }
    }
}