using ApiRepasoViernes.Models;
using ApiRepasoViernes.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRepasoViernes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private RepositoryPeliculas repo;

        public UsuariosController(RepositoryPeliculas repo)
        {
            this.repo = repo;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Registro(Usuario user)
        {
            await this.repo.InsertarUsuarioAsync(user);
            return Ok();
        }
        [Authorize]
        [HttpPut("[action]")]
        public async Task<IActionResult> EditarUsuario(Usuario user)
        {
            await this.repo.UpdateUsuarioAsync(user);
            return Ok();
        }
    }
}
