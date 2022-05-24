using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identities
{
    public class Address
    {
        [Key]
        public int Id {  get; set; }
        public string Description { get; set; }
        public Country Country { get; set; }
        public District District { get; set; }
        public Ward Ward { get; set; }
        public List<Employee> Employees { get; set; }
        // access modyfier
        internal void UpdateName(string description)
        {
            Description = description;
        }
        
    }
}
