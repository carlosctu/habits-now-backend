using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiHabits.Controllers
{
   
    public class UserController : GenericController<User, UserRepository>
    {
        public UserController() : base(new UserRepository())
        {


        }
        [HttpGet]
        public List<User> Get()
        {
            UserRepository repository = new();
            return repository.GetAll();
        }
        [HttpPost]
        public override string Post(User model)
        {
            UserRepository repository = new();
            return repository.Create(model);
        }
    }
}
