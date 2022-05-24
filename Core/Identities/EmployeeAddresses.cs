using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identities
{
    public class EmployeeAddresses
    {
        public Guid EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}
