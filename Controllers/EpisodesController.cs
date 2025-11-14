using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaCarsalesBack.Interfaces;

namespace PruebaTecnicaCarsalesBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EpisodesController : ControllerBase
    {
        private readonly IEpisodeService _service;

        public EpisodesController(IEpisodeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetEpisodes([FromQuery] int page = 1)
        {
            return Ok(await _service.GetEpisodes(page));
        }

        [HttpGet("characters")]
        public async Task<IActionResult> GetCharacters(
            [FromQuery] int page = 1,
            [FromQuery] string name = "",
            [FromQuery] string status = "")
        {
            return Ok(await _service.GetCharacters(page, name, status));
        }

        [HttpGet("locations")]
        public async Task<IActionResult> GetLocations([FromQuery] int page = 1)
        {
            return Ok(await _service.GetLocations(page));
        }

    }
}
