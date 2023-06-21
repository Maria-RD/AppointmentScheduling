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

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speciality = _context.Speciality.Find(id);

            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        [HttpPost] // Overloaded: HttpPost method to save to the DB, the other is for the View
        public IActionResult Edit(int id, [Bind("SpecialityId, Description")] Speciality speciality)
        {
            if (id != speciality.SpecialityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(speciality);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(speciality);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speciality = _context.Speciality.FirstOrDefault(e => e.SpecialityId == id);

            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var speciality = _context.Speciality.Find(id);
            _context.Speciality.Remove(speciality);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}