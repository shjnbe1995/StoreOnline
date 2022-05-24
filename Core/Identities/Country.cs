using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identities
{
    public class Country
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        internal void UpdateName(string description)
        {
            Description = description;
        }
    }
}
