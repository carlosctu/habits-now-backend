using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    internal class BaseRepositoryy<T> : IRepository<T> where T : BaseModel
    {
        public virtual string Create(T model)
        {
            //using (WarrenContext warrenContext = new WarrenContext())
            //{
            //    warrenContext.Set<T>().Add(model);
            //    // Quando manipulo dados dentro do db devo usar o SaveChanges();
            //    warrenContext.SaveChanges();
            //}
            return "Criando";
        }
        public virtual string Delete(int Id)
        {
            //using (WarrenContext warrenContext = new WarrenContext())
            //{
            //    warrenContext.Entry<T>(this.GetById(Id)).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            //    warrenContext.SaveChanges();
            //}
            return "Deletado";
        }
    }
}
