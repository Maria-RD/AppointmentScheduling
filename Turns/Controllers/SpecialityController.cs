using Microsoft.AspNetCore.Mvc;

namespace Turns.Controllers
{
    public class SpecialityController : Controller

        public SpecialityController()
        {

        }

        public IActionResult Index()
        {
        return View();
        }
}