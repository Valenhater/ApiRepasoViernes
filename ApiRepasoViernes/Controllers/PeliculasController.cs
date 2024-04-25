using ApiRepasoViernes.Models;
using ApiRepasoViernes.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRepasoViernes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private RepositoryPeliculas repo;

        public PeliculasController(RepositoryPeliculas repo)
        {
            this.repo = repo;
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<List<Pelicula>>> GetPeliculas()
        {
            return await this.repo.GetPeliculas();
        }
        [HttpGet("[action]/{idpeli}")] //El action es para que te ponga el nombre de getpelicula
        public async Task<ActionResult<Pelicula>> GetPelicula(int idpeli) //SOLO UNA PELI
        {
            return await this.repo.FindPeliculaAsync(idpeli);
        }
        [HttpPost("[action]")]
        public async Task<ActionResult<Pelicula>> CreatePelicula(Pelicula peli)
        {
            await this.repo.InsertarPeliculaAsync(peli);
            return Ok();
        }
        [HttpPut("[action]")]
        public async Task<ActionResult<Pelicula>> EditPelicula(Pelicula peli)
        {
            await this.repo.UpdatePeliculaAsync(peli);
            return Ok();
        }
        [HttpDelete("[action]/{idpeli}")]
        public async Task<ActionResult<Pelicula>> DeletePelicula(int idpeli)
        {
            await this.repo.DeletePeliculaAsync(idpeli);
            return Ok();
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<List<Genero>>> GetGeneros()
        {
            return await this.repo.GetGenerosAsync();
        }
        [HttpGet("[action]/{idgenero}")]
        public async Task<ActionResult<Genero>> GetGenero(int idgenero)
        {
            return await this.repo.FindGeneroAsync(idgenero);
        }
        [HttpGet("[action]/{idpeli}")]
        public async Task<ActionResult<List<Pelicula>>> GetPeliculasGenero(int idpeli)
        {
            return await this.repo.GetPeliculasGenero(idpeli);
        }

    }
}
