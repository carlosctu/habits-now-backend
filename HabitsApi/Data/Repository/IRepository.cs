using Data.Model;

namespace Data.Repository
{
    public interface IRepository<T> where T : BaseModel
    {
        bool Create(T model);

        string Delete(int Id);

        public bool Exist(string email);

        public List<T> GetAll();

        public T GetById(int id);

    }
}
