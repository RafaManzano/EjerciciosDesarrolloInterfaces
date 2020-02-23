using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appanimations.Models
{
    public class Drivers
    {
        public string DriverId { get; set; }
        public string Url { get; set; }
        public string CompleteName { get { return string.Format("{0} {1}", GivenName, FamilyName); } }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string DateOfBirth { get; set; }
        public string Nationality { get; set; }
    }
}
