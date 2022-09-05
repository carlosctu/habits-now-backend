using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiHabits.Controllers
{

    public class HabitController : GenericController<Habit, HabitRepository>
    {
        [HttpGet("GetByEmail/{email}")]
        public List<Habit> GetByEmail(string email)
        {
            HabitRepository repository = new HabitRepository();
            return repository.GetByEmail(email);
        }

        [HttpGet("GetByCategory/{category}")]
        public List<Habit> GetByCategory(string category)
        {

            HabitRepository repository = new();
            return repository.GetByCategory(category);
        }
    }
}
