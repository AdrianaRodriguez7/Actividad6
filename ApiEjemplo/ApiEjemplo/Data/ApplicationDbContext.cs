
//Creo una clase que representa la conexión con la base de datos y
//define las tablas mediante DbSet.
using ApiEjemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEjemplo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) 
            : base(options) { }
        public DbSet<Producto> Productos { get; set; }
    }
}
