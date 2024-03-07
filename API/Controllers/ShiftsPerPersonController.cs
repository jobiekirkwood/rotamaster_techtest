using Business;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftsPerPersonController(ShiftsService shiftsService) : ControllerBase
    {
        private readonly ShiftsService _shiftsService = shiftsService;

        //Write an endpoint which takes a name as input and returns the total number of shifts assigned to that person
        [HttpGet(Name = "GetShiftsByName")]
        public IActionResult GetShiftsByName(string name)
        {
            if (name is null)
            {
                return BadRequest("You must provide a name");
            }
            else
            {
                return Ok(_shiftsService.GetShiftsByName(name));
            }
        }



    }
}
