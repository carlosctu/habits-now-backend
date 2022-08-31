using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiHabits.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R repository;

        public GenericController(R repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public virtual string Post(T model)
        {
            return repository.Create(model);
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
    }
}
