using Microsoft.AspNetCore.Mvc;
using Turns.Models;
using System.Linq;

namespace Turns.Controllers
{
    public class SpecialityController : Controller
    {
        private readonly TurnsContext _context;

        public SpecialityController(TurnsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Speciality.ToList());
        }
    }
}