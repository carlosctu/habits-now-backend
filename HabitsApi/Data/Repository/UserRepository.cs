using ApiHabits.Context;
using Data.Model;
using Data.Utils;

namespace Data.Repository
{
    public class UserRepository : BaseRepository<User>
    {

        public override bool Create(User model)
        {
            model.Senha = Cryptografy.Criptografar(model.Senha);
            Console.WriteLine(model.Email);
            if (Exist(model.Email))
            {
                return base.Create(model);
            }
            else
            {
                Console.WriteLine(model);
                return false;
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

        public override bool Exist(string entry)
        {
            User user = null;
            using (HabitContext habitContext = new())
            {

                user = habitContext.User.Where(u => u.Email == entry).FirstOrDefault() ?? null;
                Console.WriteLine(user);
                return user == null ? true : false;
            }
        }
        public User GetByEmail(string email)
        {
            User result = null;
            using (HabitContext habit = new())
            {
                result = habit.User.Where(u => u.Email == email).FirstOrDefault();
                return result;
            }
        }
    }
}
