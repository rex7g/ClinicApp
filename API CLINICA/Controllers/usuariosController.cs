using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API_CLINICA.Data;

namespace API_CLINICA.Controllers
{
    public class usuariosController : Controller
    {
        private readonly CLINICAContext _context;

        public usuariosController(CLINICAContext context)
        {
            _context = context;
        }

        // GET: usuarios
        public async Task<IActionResult> Index()
        {
              return _context.Doctores != null ? 
                          View(await _context.Doctores.ToListAsync()) :
                          Problem("Entity set 'CLINICAContext.Doctores'  is null.");
        }

        // GET: usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Doctores == null)
            {
                return NotFound();
            }

            var doctore = await _context.Doctores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doctore == null)
            {
                return NotFound();
            }

            return View(doctore);
        }

        // GET: usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,Especialidad,Email,Telefono,Contraseña,FechaCreacion")] Doctore doctore)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doctore);
        }

        // GET: usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Doctores == null)
            {
                return NotFound();
            }

            var doctore = await _context.Doctores.FindAsync(id);
            if (doctore == null)
            {
                return NotFound();
            }
            return View(doctore);
        }

        // POST: usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido,Especialidad,Email,Telefono,Contraseña,FechaCreacion")] Doctore doctore)
        {
            if (id != doctore.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctoreExists(doctore.Id))
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
            return View(doctore);
        }

        // GET: usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Doctores == null)
            {
                return NotFound();
            }

            var doctore = await _context.Doctores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doctore == null)
            {
                return NotFound();
            }

            return View(doctore);
        }

        // POST: usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Doctores == null)
            {
                return Problem("Entity set 'CLINICAContext.Doctores'  is null.");
            }
            var doctore = await _context.Doctores.FindAsync(id);
            if (doctore != null)
            {
                _context.Doctores.Remove(doctore);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctoreExists(int id)
        {
          return (_context.Doctores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
