using DataLayer.DataContext;
using DataLayer.Entities;
using DataLayer.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Functions
{
    public class UserFunctions : IUser
    {
        // DI - dependency injection
        private readonly IDatabaseContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserFunctions(IDatabaseContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET ALL USERS
        public async Task<List<ApplicationUser>> GetAllUsers()
        {
            List<ApplicationUser> users = await _context.Users.ToListAsync();
            return users;
        }

        // ADD NEW USER 
        public async Task<Guid> CreateUser(ApplicationUser userVM, string password)
        {
            if (userVM == null)
            {
                throw new ArgumentNullException(nameof(userVM));
            }

            var result = await _userManager.CreateAsync(userVM, password);

            if (result.Errors.Any())
            {
                throw new Exception("");
            }

            return userVM.Id;
        }
        public async Task<ApplicationUser> UpdateUser(Guid id,string currentPassword, string newPassword, string email)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) throw new NotImplementedException("Cannot find user by this id");
            user.Email = email;
            var isUpdateEmail = await _userManager.UpdateAsync(user);
            if(!isUpdateEmail.Succeeded) throw new NotImplementedException("cannot update Email");
            var isUpdatePassword = await _userManager.ChangePasswordAsync(user, currentPassword,newPassword);
            if (!isUpdatePassword.Succeeded) throw new NotImplementedException("cannot update Password");
            return user;
        }

        public async Task<Boolean> DeleteUser(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) throw new NotImplementedException("Cannot find user by this id");
            var isDeleteUser = await _userManager.DeleteAsync(user);
            if (!isDeleteUser.Succeeded) return false;
            return true;
        }
    }
}
