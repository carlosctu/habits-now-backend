using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiHabits.Controllers
{

    public class DutyController : GenericController<Duty, DutyRepository>
    {
        [HttpGet("GetByEmail/{email}")]
        public List<Duty> GetByEmail(string email)
        {
            DutyRepository repository = new DutyRepository();
            return repository.GetByEmail(email);
        }

        [HttpGet("GetByCategory/{category}")]
        public List<Duty> GetByCategory(string category)
        {

            DutyRepository repository = new();
            return repository.GetByCategory(category);
        }
    }
}
