using ApiRepasoViernes.Models;
using ApiRepasoViernes.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiRepasoViernes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        private RepositoryPeliculas repo;

        public ComprasController(RepositoryPeliculas repo)
        {
            this.repo = repo;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Comprar(Compra compra)
        {
            string jsonUsuario = HttpContext.User.FindFirst(x => x.Type == "UserData").Value;
            Usuario usuarioLogeado = JsonConvert.DeserializeObject<Usuario>(jsonUsuario);
            compra.IdUsuario = usuarioLogeado.IdUsuario;
            await this.repo.InsertarCompraAsync(compra);
            return Ok();
        }
        [Authorize]
        [HttpGet("[action]")]
        public async Task<ActionResult<List<Compra>>> GetCompras()
        {
            return await this.repo.GetCompras();
        }
    }
}
