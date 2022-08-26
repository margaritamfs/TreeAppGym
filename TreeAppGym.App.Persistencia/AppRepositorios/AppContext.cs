using Microsoft.EntityFrameworkCore;
using TreeAppGym.App.Dominio;
namespace TreeAppGym.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Clientes> Clientes {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("DataSource = (localdb)\\MSSQLLocalDB; Initial Catalog=TreeAppGymtData ");
        }
    }
    }
}
