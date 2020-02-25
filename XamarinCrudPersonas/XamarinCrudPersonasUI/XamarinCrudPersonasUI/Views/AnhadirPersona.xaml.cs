﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCrudPersonasUI.ModelViews;

namespace XamarinCrudPersonasUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnhadirPersona : ContentPage
    {
        public AnhadirPersona()
        {
            InitializeComponent();
            BindingContext = new AnhadirPersonaVM();
        }
    }
}