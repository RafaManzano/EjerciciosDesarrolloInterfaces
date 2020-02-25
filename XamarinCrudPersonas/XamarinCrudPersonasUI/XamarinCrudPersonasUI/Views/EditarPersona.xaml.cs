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
    public partial class EditarPersona : ContentPage
    {
        public EditarPersona(clsPersona persona)
        {
            InitializeComponent();
            BindingContext = new EditarPersonaVM(persona);
        }
    }
}