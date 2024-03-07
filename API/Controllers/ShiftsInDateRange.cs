using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftsInDateRange(ShiftsService shiftsService) : ControllerBase
    {
        private readonly ShiftsService _shiftsService = shiftsService;

        //Write an endpoint that retrieves a list of shifts for active people where the shift starts between two dates.
        [HttpGet(Name = "GetShiftsStartsInDateRangeForActivePeople")]
        public IActionResult GetShiftsStartsInDateRangeForActivePeople(DateTime? startFirstDate, DateTime? startLastDate)
        {
            if (startFirstDate is null || startLastDate is null)
            {
                return BadRequest("You must enter a start and end date");
            }
            
            if (startFirstDate > startLastDate)
            {
                return BadRequest("The start date must be before the end date");
            }

            return Ok(_shiftsService.GetShiftsStartsInDateRangeForActivePeople(startFirstDate.Value, startLastDate.Value));
        }

    }
}
