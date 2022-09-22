using Microsoft.EntityFrameworkCore;
using TreeAppGym.App.Dominio;
namespace TreeAppGym.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<PlanNutricional> PlanNutricional {get; set;}
        public DbSet<Rutina> Rutinas {get; set;}
        public DbSet<Gym> Gyms {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //string conexión nube
            // optionsBuilder.UseSqlServer("Data Source=SQL8002.site4now.net;Initial Catalog=db_a8d1c4_gymhouse;User Id=db_a8d1c4_gymhouse_admin;Password=qazwsx0101");
            //string conexión local
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=Gimnasio");
        }
    }
    }
}
