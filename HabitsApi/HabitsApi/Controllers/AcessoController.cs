using Data.DTO;
using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiHabits.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcessoController : ControllerBase
    {
        [HttpPost("Logon")]
        public User Logon(UserDto userDto)
        {
            UserRepository repository = new();
            User model = repository.Logon(userDto.Email, userDto.Senha);
            return model;
        }
    }
}
