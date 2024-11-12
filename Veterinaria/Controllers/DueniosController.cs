/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VeterinariaPichichus.Context;
using VeterinariaPichichus.Models;
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VeterinariaPichichus.Context;
using VeterinariaPichichus.Models;


namespace VeterinariaPichichus.Controllers
{
    public class DueniosController : Controller
    {
        private readonly DuenioContext _context;

        public DueniosController(DuenioContext context)
        {
            _context = context;
        }

        // GET: Duenios
        public async Task<IActionResult> Index()
        {
            var duenioContext = _context.Duenios.Include(d => d.MascotaDuenio);
            return View(await duenioContext.ToListAsync());
        }

        // GET: Duenios/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duenio = await _context.Duenios
                .Include(d => d.MascotaDuenio)
                .FirstOrDefaultAsync(m => m.DNI == id);
            if (duenio == null)
            {
                return NotFound();
            }

            return View(duenio);
        }

        // GET: Duenios/Create
        public IActionResult Create()
        {
            ViewData["MascotaId"] = new SelectList(_context.Mascotas, "idMascota", "idMascota");
            return View();
        }

        // POST: Duenios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DNI,Nombre,Apellido,Email,Telefono,MascotaId")] Duenio duenio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(duenio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MascotaId"] = new SelectList(_context.Mascotas, "idMascota", "idMascota", duenio.MascotaId);
            return View(duenio);
        }

        // GET: Duenios/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duenio = await _context.Duenios.FindAsync(id);
            if (duenio == null)
            {
                return NotFound();
            }
            ViewData["MascotaId"] = new SelectList(_context.Mascotas, "idMascota", "idMascota", duenio.MascotaId);
            return View(duenio);
        }

        // POST: Duenios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DNI,Nombre,Apellido,Email,Telefono,MascotaId")] Duenio duenio)
        {
            if (id != duenio.DNI)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(duenio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DuenioExists(duenio.DNI))
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
            ViewData["MascotaId"] = new SelectList(_context.Mascotas, "idMascota", "idMascota", duenio.MascotaId);
            return View(duenio);
        }

        // GET: Duenios/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duenio = await _context.Duenios
                .Include(d => d.MascotaDuenio)
                .FirstOrDefaultAsync(m => m.DNI == id);
            if (duenio == null)
            {
                return NotFound();
            }

            return View(duenio);
        }

        // POST: Duenios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var duenio = await _context.Duenios.FindAsync(id);
            if (duenio != null)
            {
                _context.Duenios.Remove(duenio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DuenioExists(string id)
        {
            return _context.Duenios.Any(e => e.DNI == id);
        }
    }
}
