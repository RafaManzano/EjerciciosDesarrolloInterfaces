using Appanimations.Models;
using Appanimations.Services.CustomersService;
using Appanimations.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace Appanimations.ViewModels
{
    public class ListaSinAnimationPageViewModel : ViewModelBase
    {
        private ObservableCollection<Customer> _listaCustomers = new ObservableCollection<Customer>();
        public ObservableCollection<Customer> ListaCustomers
        {
            get { return _listaCustomers; }
            set
            {
                _listaCustomers = value;
                RaisePropertyChanged();
            }
        }
        private ICustomerService _customerService;

        public ListaSinAnimationPageViewModel(ICustomerService custoemrService)
        {
            _customerService = custoemrService;
        }

        public override Task OnNavigatedFrom(NavigationEventArgs args)
        {
            return null;
        }

        public async override Task OnNavigatedTo(NavigationEventArgs args)
        {
            ListaCustomers = new ObservableCollection<Customer>( await _customerService.GetCustomers());
        }
    }
}
