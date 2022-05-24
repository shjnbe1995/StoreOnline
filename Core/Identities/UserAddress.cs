using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identities
{
    public class UserAddress
    {
        public Guid UserId { get; set; }
        public ApplicationUser<Guid> User { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
