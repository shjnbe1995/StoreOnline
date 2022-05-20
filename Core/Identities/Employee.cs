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
        //public string Address { get; set; }
        public int AddresssId { get; set; }
        public Address Addresss { get; set; }

        OOP
        void ChangeAddress(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("No address data");
            }
            Addresss.UpdateName(name);
        }

        //void AddAddress(string name)
        //{
        //    if (name == null)
        //    {
        //        throw new ArgumentNullException("No address data");
        //    }
        //    var c = new Address();
        //    Addresss = c;
        //}*/
    }
}
