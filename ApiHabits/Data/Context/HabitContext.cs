using Microsoft.EntityFrameworkCore;
using Data.Model;
using System.Collections.Generic;
using System.Numerics;

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
        }
    }
}
