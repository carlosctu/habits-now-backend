using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiHabits.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R repository = Activator.CreateInstance<R>();

        [HttpPost]
        public virtual StatusCodeResult Post(T model)
        {
            if (String.IsNullOrEmpty(repository.Create(model)))
            {
                return new StatusCodeResult(StatusCodes.Status200OK);
            }
            return new StatusCodeResult(StatusCodes.Status409Conflict);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return repository.Delete(id);
        }
        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        [HttpGet]
        public List<T> Get()
        {
            return repository.GetAll();
        }
    }
}
