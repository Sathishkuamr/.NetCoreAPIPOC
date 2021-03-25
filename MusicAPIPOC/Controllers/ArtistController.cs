using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicLibrary.Service.Interface;

namespace MusicAPIPOC.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistService _artistService;
        private readonly ILogger _logger;

        public ArtistController(IArtistService artistService, ILogger<ArtistController> logger)
        {
            _artistService = artistService;
            _logger = logger;
        }

        [Route("/api/artists")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllArtists()
        {
            try
            {
                return Ok(await _artistService.GetArtistDetails());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [Route("/api/artist/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllArtistById(int artistId)
        {
            try
            {
                return Ok(await _artistService.GetArtistById(artistId));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}