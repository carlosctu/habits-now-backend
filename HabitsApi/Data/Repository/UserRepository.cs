using ApiHabits.Context;
using Data.Model;
using Data.Utils;

namespace Data.Repository
{
    public class UserRepository : BaseRepository<User>
    {

        public override string Create(User model)
        {
            model.Senha = Cryptografy.Criptografar(model.Senha);
            if (Exist(model.Email)!)
            {
                return base.Create(model);
            }
            else
            {
                return "";
            }
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
    }
}
