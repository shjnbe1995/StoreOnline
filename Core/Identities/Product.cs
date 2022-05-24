using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Code { get; set; }
        public string Reviews { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public string SerialNumber { get; set; }
        public string Sample { get; set; }
        public string Image { get; set; }
        public List<UOM> UOM { get; set; }
        public Category Category { get; set; }
        public Warehouse Warehouse { get; set; }
        public List<Promotion> Promotion { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string CreateBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
