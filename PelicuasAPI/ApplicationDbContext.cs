using Microsoft.EntityFrameworkCore;
using PelicuasAPI.Entidades;

namespace PelicuasAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
    }

    
}
