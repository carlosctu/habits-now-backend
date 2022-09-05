using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiHabits.Controllers
{

    public class UserController : GenericController<User, UserRepository>
    {
        [HttpGet("NotExist")]
        public bool Exist([FromQuery] string email)
        {
            UserRepository userRepository = new UserRepository();
            return userRepository.Exist(email);
        }

        [HttpGet("{email}")]
        public User GetByEmail(string email)
        {
            UserRepository repository = new();
            return repository.GetByEmail(email);
        }
    }
}
