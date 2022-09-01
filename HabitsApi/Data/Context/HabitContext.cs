using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiHabits.Context
{
    public class HabitContext : DbContext
    {

        #region Props
        public DbSet<User> User { get; set; }
        public DbSet<Habit> Habit { get; set; }
        public DbSet<Duty> Duty { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=zuplae.vps-kinghost.net; Port=5441; Database=postgres; UserId=postgres; Password=123456");
            //optionsBuilder.UseNpgsql("Host=grupo_1; Port=5432; Database=postgres; UserId=postgres; Password=123456");
        }
    }
}
