using ApiRepasoViernes.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRepasoViernes.Data
{
    public class PeliculasContext:DbContext
    {
        public PeliculasContext(DbContextOptions<PeliculasContext> options) : base(options) { }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Compra> Compras { get; set; }
    }
}
