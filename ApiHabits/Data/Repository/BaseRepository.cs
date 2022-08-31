using ApiHabits.Context;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
