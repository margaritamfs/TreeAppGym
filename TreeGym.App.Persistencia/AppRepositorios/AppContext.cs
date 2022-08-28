using Microsoft.EntityFrameworkCore;
using TreeGym.App.Dominio;

namespace TreeGym.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Gym> Gyms {get;set;}
        public DbSet<PlanNutricional> PlanesNutricionales {get;set;}
        public DbSet<Rutina> Rutinas {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= Gimnasio");
        }
    }
    }
}