using ApiRepasoViernes.Data;
using ApiRepasoViernes.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRepasoViernes.Repositories
{
    public class RepositoryPeliculas
    {
        private PeliculasContext context;

        public RepositoryPeliculas(PeliculasContext context)
        {
            this.context = context;
        }

        public async Task<List<Pelicula>> GetPeliculas()
        {
            return await this.context.Peliculas.ToListAsync();
        }
        public async Task<Pelicula> FindPeliculaAsync(int idPelicula)
        {
            return await this.context.Peliculas.FirstOrDefaultAsync(x => x.IdPelicula == idPelicula);
        }
        public async Task InsertarPeliculaAsync(Pelicula peli)
        {
            this.context.Peliculas.Add(peli);
            await this.context.SaveChangesAsync();
        }
        public async Task UpdatePeliculaAsync(Pelicula peli)
        {
            this.context.Peliculas.Update(peli);
            await this.context.SaveChangesAsync();
        }
        public async Task DeletePeliculaAsync(int id)
        {
            Pelicula peli = await this.FindPeliculaAsync(id);
            this.context.Peliculas.Remove(peli);
            await this.context.SaveChangesAsync();
        }
        public async Task<List<Genero>> GetGenerosAsync()
        {
            return await this.context.Generos.ToListAsync();
        }
        public async Task<Genero> FindGeneroAsync(int idGenero)
        {
            return await this.context.Generos.FirstOrDefaultAsync(x => x.IdGenero == idGenero);
        }
        public async Task<List<Pelicula>> GetPeliculasGenero(int idGenero)
        {
            return await this.context.Peliculas.Where(x => x.IdGenero == idGenero).ToListAsync();
        }
        public async Task<List<Usuario>> getUsuarios()
        {
            return await this.context.Usuarios.ToListAsync();
        }
        public async Task InsertarUsuarioAsync(Usuario user)
        {
            this.context.Usuarios.Add(user);
            await this.context.SaveChangesAsync();
        }
        public async Task UpdateUsuarioAsync(Usuario user)
        {
            this.context.Usuarios.Update(user);
            await this.context.SaveChangesAsync();
        }
        public async Task<Usuario> LoginAsync(string nombre, string password)
        {
            return await this.context.Usuarios.Where(x => x.Nombre == nombre && x.Password == password).FirstOrDefaultAsync();
        }
        public async Task<List<Compra>> GetCompras()
        {
            return await this.context.Compras.ToListAsync();
        }
        public async Task InsertarCompraAsync(Compra compra)
        {
            this.context.Compras.Add(compra);
            await this.context.SaveChangesAsync();
        }


    }
}
