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
        public Guid Id {  get; set; }
        public string Name { get; set; }
        // access modyfier
        internal void UpdateName(string name)
        {
            Name = name;
        }
    }
}
