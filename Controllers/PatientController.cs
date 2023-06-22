using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TurnsBackFront.Models;

namespace TurnsBackFront.Controllers
{
    public class PatientController : Controller
    {
        private readonly TurnsContext _context;

        public PatientController(TurnsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Patient.ToListAsync());
        }
    }
}
