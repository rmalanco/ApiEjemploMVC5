using ApiEjemploMVC5.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;

namespace ApiEjemploMVC5.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Desactivar la verificación de compatibilidad del modelo
            Database.SetInitializer<AppDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
