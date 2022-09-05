using ApiHabits.Context;
using Data.Model;

namespace Data.Repository
{
    public class DutyRepository : BaseRepository<Duty>
    {
        public List<Duty> GetByEmail(string email)
        {
            List<Duty> result = new();
            using (HabitContext habit = new())
            {
                result = habit.Duty.Where(u => u.UserEmail == email).ToList();
                return result;
            }
        }

        public List<Duty> GetByCategory(string category)
        {
            List<Duty> result;
            using (HabitContext context = new())
            {
                result = context.Duty.Where(u => u.Category == category).ToList() ?? new();
                return result;
            }

        }
    }
}
