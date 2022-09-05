using ApiHabits.Context;
using Data.Model;

namespace Data.Repository
{
    public class HabitRepository : BaseRepository<Habit>
    {
        public List<Habit> GetByEmail(string email)
        {
            List<Habit> result;
            using (HabitContext habit = new())
            {
                result = habit.Habit.Where(u => u.UserEmail == email).ToList() ?? new();
                return result;
            }
        }
        public List<Habit> GetByCategory(string category)
        {
            List<Habit> result;
            using (HabitContext context = new())
            {
                result = context.Habit.Where(u => u.Category == category).ToList() ?? new();
                return result;
            }

        }
    }
}
