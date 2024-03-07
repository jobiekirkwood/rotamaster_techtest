using Business;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController(ShiftsService shiftsService) : ControllerBase
    {
        private readonly ShiftsService _shiftsService = shiftsService;

        //Write an endpoint which returns an array of role and the total number of shifts assigned to that role in descending order.
        [HttpGet(Name = "GetRolesAndShiftCount")]
        public IActionResult GetRolesAndShiftCount()
        {
            return Ok(_shiftsService.GetRolesAndShiftCountDescCountOrder());
        }
    }
}
