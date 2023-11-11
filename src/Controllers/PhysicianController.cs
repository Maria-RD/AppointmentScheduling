using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TurnsBackFront.Models;

namespace TurnsBackFront.Controllers
{
    public class PhysicianController : Controller
    {
        private readonly TurnsContext _context;

        public PhysicianController(TurnsContext context)
        {
            _context = context;
        }

        // GET: Physician
        public async Task<IActionResult> Index()
        {
            return View(await _context.Physician.ToListAsync());
        }

        // GET: Physician/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Physician physician = await _context.Physician
                .Where(p => p.PhysicianId == id).Include(ps => ps.PhysicianSpeciality)
                .ThenInclude(s => s.Speciality).FirstOrDefaultAsync();

            if (physician == null)
            {
                return NotFound();
            }

            return View(physician);
        }

        // GET: Physician/Create
        public IActionResult Create()
        {
            ViewData["ListSpecialities"] = new SelectList(_context.Speciality, "SpecialityId", "Description");
            return View();
        }

        // POST: Physician/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhysicianId,Name,Surname,Address,Phone,Email,OpeningHoursFrom,OpeningHoursTo")] Physician physician, int SpecialityId)
        {
            if (ModelState.IsValid)
            {
                _context.Add(physician);
                await _context.SaveChangesAsync();

                PhysicianSpeciality physicianSpeciality = new PhysicianSpeciality();
                physicianSpeciality.PhysicianId = physician.PhysicianId;
                physicianSpeciality.SpecialityId = SpecialityId;

                _context.Add(physicianSpeciality);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(physician);
        }

        // GET: Physician/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Physician physician = await _context.Physician.Where(p => p.PhysicianId == id) // FindAsync(id);
                .Include(ps => ps.PhysicianSpeciality).FirstOrDefaultAsync();

            if (physician == null)
            {
                return NotFound();
            }

            if (!physician.PhysicianSpeciality.Any())
            {
                return NotFound();
            }

            ViewData["ListSpecialities"] = new SelectList(
                _context.Speciality, "SpecialityId", "Description", physician.PhysicianSpeciality[0].SpecialityId);

            return View(physician);
        }

        // POST: Physician/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhysicianId,Name,Surname,Address,Phone,Email,OpeningHoursFrom,OpeningHoursTo")] Physician physician, int SpecialityId)
        {
            if (id != physician.PhysicianId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(physician);
                    await _context.SaveChangesAsync();

                    PhysicianSpeciality specialityPhysician = await _context.PhysicianSpeciality
                        .FirstOrDefaultAsync(ps => ps.PhysicianId == id);

                    _context.Remove(specialityPhysician);
                    await _context.SaveChangesAsync();

                    specialityPhysician.SpecialityId = SpecialityId;
                    _context.Add(specialityPhysician);

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhysicianExists(physician.PhysicianId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(physician);
        }

        // GET: Physician/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Physician physician = await _context.Physician
                .FirstOrDefaultAsync(p => p.PhysicianId == id);

            if (physician == null)
            {
                return NotFound();
            }

            return View(physician);
        }

        // POST: Physician/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            PhysicianSpeciality physicianSpeciality = await _context.PhysicianSpeciality
                .FirstOrDefaultAsync(ph => ph.PhysicianId == id);

            _context.PhysicianSpeciality.Remove(physicianSpeciality);
            await _context.SaveChangesAsync();

            Physician physician = await _context.Physician.FindAsync(id);
            _context.Physician.Remove(physician);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhysicianExists(int id)
        {
            return _context.Physician.Any(p => p.PhysicianId == id);
        }
    }
}
