using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identities
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public List<Address> Address { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        //OOP
        void ChangeAddress(int addressId, string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("No address data");
            }
            foreach(var item in Address)
            {
                if(item.Id == addressId)
                {
                    item.UpdateName(name);
                }
            }
        }
    }
}
