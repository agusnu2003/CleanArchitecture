using Aplicacion;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoJuegoController : ControllerBase
    {
        private readonly VideoJuegoService _service;

        public VideoJuegoController (VideoJuegoService videoJuegoService)
        {
            _service = videoJuegoService  ;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.ObtenerTodos());
        }
        [HttpPost]
        public IActionResult Post([FromBody] VideoJuego videoJuego)
        {
            _service.crearvideojuego(videoJuego);
            return Ok("Videojuego creado con éxito.");
        }

        [HttpPut]
        public IActionResult Put([FromBody] VideoJuego videoJuego)
        {
            _service.update(videoJuego);
            return Ok("Videojuego actualizado con éxito.");
        }
    }
}
