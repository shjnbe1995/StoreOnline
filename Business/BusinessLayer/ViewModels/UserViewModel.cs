using System.ComponentModel.DataAnnotations;

namespace DomainCore.ViewModels
{
    public class UserViewModel
    {
        public class UserVM
        {
            public Guid Id { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string NewPassword { get; set; }
            public string ConfirmedNewPassword { get; set; }
            public string FullName { get; set; }
            public string Gender { get; set; }
            public string Address { get; set; }
            public string State { get; set; }            
            public string City { get; set; }
        }
    }
}
