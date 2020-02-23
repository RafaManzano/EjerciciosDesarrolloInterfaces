using Appanimations.Services.CustomersService;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appanimations.ViewModels.Base
{
    public class ViewModelLocator
    {
        readonly IUnityContainer _container;

        public ViewModelLocator()
        {
            _container = new UnityContainer();

            _container.RegisterType<MainPageViewModel>();
            _container.RegisterType<DoubleAnimationPageViewModel>();
            _container.RegisterType<DoubleAnimationPageUsingKeyFramesViewModel>();
            _container.RegisterType<ColorAnimationPageViewModel>();
            _container.RegisterType<PointAnimationPageViewModel>();
            _container.RegisterType<EasingFunctionPageViewModel>();
            _container.RegisterType<ListaSinAnimationPageViewModel>();
            _container.RegisterType<ListaConAnimationPageViewModel>();

            _container.RegisterType<ICustomerService, CurstomerService>(new ContainerControlledLifetimeManager());

        }

        public MainPageViewModel MainPageViewModel
        {
            get { return _container.Resolve<MainPageViewModel>(); }
        }
        public DoubleAnimationPageViewModel DoubleAnimationPageViewModel
        {
            get { return _container.Resolve<DoubleAnimationPageViewModel>(); }
        }
        public DoubleAnimationPageUsingKeyFramesViewModel DoubleAnimationPageUsingKeyFramesViewModel
        {
            get { return _container.Resolve<DoubleAnimationPageUsingKeyFramesViewModel>(); }
        }
        public ColorAnimationPageViewModel ColorAnimationPageViewModel
        {
            get { return _container.Resolve<ColorAnimationPageViewModel>(); }
        }
        public PointAnimationPageViewModel PointAnimationPageViewModel
        {
            get { return _container.Resolve<PointAnimationPageViewModel>(); }
        }
        public EasingFunctionPageViewModel EasingFunctionPageViewModel
        {
            get { return _container.Resolve<EasingFunctionPageViewModel>(); }
        }
        public ListaSinAnimationPageViewModel ListaSinAnimationPageViewModel
        {
            get { return _container.Resolve<ListaSinAnimationPageViewModel>(); }
        }
        public ListaConAnimationPageViewModel ListaConAnimationPageViewModel
        {
            get { return _container.Resolve<ListaConAnimationPageViewModel>(); }
        }
    }
}
