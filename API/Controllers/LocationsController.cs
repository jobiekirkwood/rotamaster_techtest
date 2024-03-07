using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController(ShiftsService shiftsService) : ControllerBase
    {
        private readonly ShiftsService _shiftsService = shiftsService;


        // Write an endpoint which returns a list of unique locations.
        [HttpGet(Name = "GetUniqueLocations")]
        public IActionResult GetUniqueLocations()
        {
            return Ok(ShiftsService.GetUniqueLocations());
        }
    }
}
