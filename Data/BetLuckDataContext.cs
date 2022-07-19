using betluck.Data.Mappings;
using betluck.Models;
using Microsoft.EntityFrameworkCore;

namespace betluck.Data
{
    public class BetLuckDataContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer("Server=localhost,1433;Database=BetLuck;User ID=sa;Password=SeuPassword do BD docker");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TeamMap());
        }
    }
}
