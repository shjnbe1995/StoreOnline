using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identities
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Discount { get; set; }
        public bool Freeship { get; set; }
        public List<Product> Products { get; set; }
    }
}
