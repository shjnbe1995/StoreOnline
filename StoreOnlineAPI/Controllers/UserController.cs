using DomainCore.UserBLL;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using static DomainCore.ViewModels.UserViewModel;

namespace StoreOnlineAPI.Controllers
{
    [ApiController]
    [Route("api/user/")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userBLL;
        public UserController(IUserService userBLL)
        {
            _userBLL = userBLL;
        }

        [HttpGet("all")]
        public async Task<List<ApplicationUser>> GetUsers()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            users = await _userBLL.GetAllUsers();
            if (users.Count > 0)
            {
                return users;
            }
            return users;
        }

        [HttpPost("add")]
        public async Task<Guid> AddUser(UserVM user)
        {
            return await _userBLL.CreateNewUser(user);
        }

        [HttpGet("delete")]
        public async Task<Boolean> DeleteUser(Guid id)
        {
            return await _userBLL.DeleteUser(id);
        }

        [HttpPut("update")]
        public async Task<ApplicationUser> UpdateUser(UserVM user)
        {
            return await _userBLL.UpdateUser(user);
        }
    }
}
