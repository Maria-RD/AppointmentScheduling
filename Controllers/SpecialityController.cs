using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TurnsBackFront.Models;

namespace TurnsBackFront.Controllers
{
    public class SpecialityController : Controller
    {
        private readonly TurnsContext _context;

        public SpecialityController(TurnsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Speciality.ToListAsync());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speciality = await _context.Speciality.FindAsync(id);

            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        [HttpPost] // Overloaded: HttpPost method to save to the DB, the other is for the View
        public async Task<IActionResult> Edit(int id, [Bind("SpecialityId, Description")] Speciality speciality)
        {
            if (id != speciality.SpecialityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(speciality);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(speciality);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speciality = await _context.Speciality.FirstOrDefaultAsync(e => e.SpecialityId == id);

            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var speciality = await _context.Speciality.FindAsync(id);
            _context.Speciality.Remove(speciality);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpecialityId, Description")] Speciality speciality)
        {
            if (ModelState.IsValid)
            {
                _context.Add(speciality);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


    }
}