using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiHabits.Controllers
{
    
    public class HabitController : GenericController<Habit, HabitRepository>
    {
        public HabitController() : base(new HabitRepository())
        {

        }

    }
}
