using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace ApiHabits.Controllers
{
   
    public class DutyController : GenericController<Duty, DutyRepository>
    {
        public DutyController() : base(new DutyRepository())
        {

        }
    }
}
