using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiHabits.Controllers
{

    public class UserController : GenericController<User, UserRepository>
    {
        [HttpGet("Exist")]
        public bool Exist([FromQuery] string email)
        {
            UserRepository userRepository = new UserRepository();
            return userRepository.Exist(email);
        }
    }
}
