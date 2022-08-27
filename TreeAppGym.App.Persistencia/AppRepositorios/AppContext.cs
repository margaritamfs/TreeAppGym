using Microsoft.EntityFrameworkCore;
using TreeAppGym.App.Dominio;
namespace TreeAppGym.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Clientes> Clientes {get;set;}
        public DbSet<PlanNutricional> PlanNutricional {get; set;}
        public DbSet<Rutina> Rutina {get; set;}
        public DbSet<Gym> Gym {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=Gimnasio ");
        }
    }
    }
}
