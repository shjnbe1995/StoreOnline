using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identities
{
    public class ApplicationUser<Guid> : IdentityUser
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public List<Address> Address { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
