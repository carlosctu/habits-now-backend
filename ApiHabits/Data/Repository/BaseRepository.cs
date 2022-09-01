using ApiHabits.Context;
using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual string Create(T model)
        {
            using (HabitContext warrenContext = new())
            {
                warrenContext.Set<T>().Add(model);
                // Quando manipulo dados dentro do db devo usar o SaveChanges();
                warrenContext.SaveChanges();
            }
            return "Criando";
        }
        public virtual string Delete(int Id)
        {
            using (HabitContext warrenContext = new())
            {
                warrenContext.Entry<T>(this.GetById(Id)).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                warrenContext.SaveChanges();
            }
            return "Deletado";
        }
        public virtual T GetById(int id)
        {
            T model = null;
            using (HabitContext habitContext = new())
            {
                model = habitContext.Set<T>().Find(id);
            }

            return model;
        }

        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();
            using (HabitContext habitContext = new())
            {
                list = habitContext.Set<T>().ToList();
            }

            return list;
        }

        public bool Exist(string email)
        {
            User user = null;
            using (HabitContext habitContext = new())
            {

                user = habitContext.User.Where(u => u.Email == email).FirstOrDefault() ?? null;
                return user != null ? true : false;
            }
        }
    }
}
