using ApiHabits.Context;
using Data.Model;
using Data.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository : BaseRepository<User>
    {

        public override string Create(User model)
        {
            model.Senha = Cryptografy.Criptografar(model.Senha);

            return base.Create(model);
        }
        public User Logon(string email, string senha)
        {
            senha = Cryptografy.Criptografar(senha);
            User user = new();
            using (HabitContext contexto = new())
            {
                user = contexto.User.Where(u => u.Email == email && u.Senha == senha).FirstOrDefault();

            }
            return user;
        }
        public virtual List<User> GetAll()
        {
            List<User> list = new List<User>();
            using (HabitContext habitContext = new())
            {
                list = habitContext.Set<User>().ToList();
            }



            return list;
        }
       
    }
}
