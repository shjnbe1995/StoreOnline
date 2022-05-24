using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identities
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Inventory { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public List<Employee> Employee { get; set; }
    }
}
