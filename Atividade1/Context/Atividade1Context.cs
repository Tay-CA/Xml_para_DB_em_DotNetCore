using Atividade1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Atividade1.Context
{
    // Contexto
    public class Atividade1Context : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=Atividade1;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasKey(t => t.Id).IsClustered();
        }
    }
}
