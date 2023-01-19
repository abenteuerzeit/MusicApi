using Api.DTOs.Songs;
using Api.Services.Songs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("songs")]
    public class SongsController : ControllerBase
    {
        private readonly SongService _service;
        private readonly ILogger<SongsController> _logger;

        public SongsController(ILogger<SongsController> logger, SongService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetSongRequest request)
        {
            _logger.LogInformation("Get songs");
            var songs = await _service.SearchAsync(request);
            return Ok(songs);
        }

    }
}
