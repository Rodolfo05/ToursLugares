using Core.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infraestructura.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Lugar> Lugar { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Encargado de crear las migraciones
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //va a buscar las configuraciones en carpeta Datos/Config
        }
    }
}
