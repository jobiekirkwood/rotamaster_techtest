using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ShiftsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
