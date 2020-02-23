using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appanimations.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Windows.Data.Json;

namespace Appanimations.Services.CustomersService
{
    public class CurstomerService : ICustomerService
    {
        public async Task<List<Customer>> GetCustomers()
        {
            var url = "http://w3schools.com/angular/customers.php";

            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(url);
                    var json = await client.GetStringAsync("");
                    var r = JsonConvert.DeserializeObject<Record>(json);
                    return r.records;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
