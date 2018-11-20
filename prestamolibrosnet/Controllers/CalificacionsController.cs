using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prestamolibrosnet.Data;
using prestamolibrosnet.Models;

namespace prestamolibrosnet.Controllers
{
    [Authorize]
    public class CalificacionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalificacionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Calificacions
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.FindFirst(ClaimTypes.Name).Value;
                ViewBag.userName = userName;
            }
            ViewBag.listaPrestamos = _context.Prestamo.ToList();
            ViewBag.listaLibros = _context.Libro.ToList();
            return View(await _context.Calificacion.ToListAsync());
        }

        // GET: Calificacions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificacion = await _context.Calificacion
                .FirstOrDefaultAsync(m => m.id == id);
            if (calificacion == null)
            {
                return NotFound();
            }

            return View(calificacion);
        }

        // GET: Calificacions/Create
        public IActionResult Create(string myvar)
        {
            int prestamoid = Convert.ToInt32(myvar);
            ViewBag.prestamoid = prestamoid;
            return View();
        }

        // POST: Calificacions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,idPrestamo, evaluacion,observacion")] Calificacion calificacion)
        {
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.FindFirst(ClaimTypes.Name).Value;
                calificacion.OwnerID = userName;
            }

            if (ModelState.IsValid)
            {
                _context.Add(calificacion);
                //Prestamo prestamo = _context.Prestamo.Where(e => e.id == calificacion.idPrestamo).Single();
                //prestamo.fechaDevolucion = DateTime.Today;
                //_context.Update(prestamo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calificacion);
        }

        // GET: Calificacions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificacion = await _context.Calificacion.FindAsync(id);
            if (calificacion == null)
            {
                return NotFound();
            }
            return View(calificacion);
        }

        // POST: Calificacions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,evaluacion,observacion")] Calificacion calificacion)
        {
            if (id != calificacion.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calificacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalificacionExists(calificacion.id))
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
            return View(calificacion);
        }

        // GET: Calificacions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificacion = await _context.Calificacion
                .FirstOrDefaultAsync(m => m.id == id);
            if (calificacion == null)
            {
                return NotFound();
            }

            return View(calificacion);
        }

        // POST: Calificacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calificacion = await _context.Calificacion.FindAsync(id);
            _context.Calificacion.Remove(calificacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalificacionExists(int id)
        {
            return _context.Calificacion.Any(e => e.id == id);
        }
    }
}
