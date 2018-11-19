using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prestamolibrosnet.Data;
using prestamolibrosnet.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace prestamolibrosnet.Controllers
{
    [Authorize]
    public class LibroesController : Controller
    {
        private readonly ApplicationDbContext _context;
      

        public LibroesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Libroes
        public async Task<IActionResult> Index(string searchString, string searchAutor)
        {
            // ViewBag.userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.FindFirst(ClaimTypes.Name).Value;
                ViewBag.userName = userName;
            }

            var libros = from m in _context.Libro
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                libros = libros.Where(s => s.titulo.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(searchAutor))
            {
                libros = libros.Where(x => x.autor.Contains(searchAutor));
            }

            return View(await libros.ToListAsync());
            //return View(await _context.Libro.ToListAsync());
        }

        public async Task<IActionResult> LibrosDisponibles(string searchString, string searchAutor)
        {
            var userName = "";
            if (User.Identity.IsAuthenticated)
            {
                userName = User.FindFirst(ClaimTypes.Name).Value;
                ViewBag.userName = userName;
            }

            var libros = from m in _context.Libro
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                libros = libros.Where(s => s.titulo.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(searchAutor))
            {
                libros = libros.Where(x => x.autor.Contains(searchAutor));
            }

            return View(await libros.ToListAsync());
            //return View(await _context.Libro.ToListAsync());
        }

        // GET: Libroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var usuarioId = User.Identity.GetUserId()
            //strCurrentUserId = User.Identity.GetUserId();

            var libro = await _context.Libro
                .FirstOrDefaultAsync(m => m.id == id);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        // GET: Libroes/Create
        public IActionResult Create()
        {            
            return View();
        }

        // POST: Libroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,isbn,titulo,autor,fecha,editorial,estado")] Libro libro)
        {
            libro.prestado = false;
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.FindFirst(ClaimTypes.Name).Value;
                libro.OwnerID = userName;
            }
            if (ModelState.IsValid)
            {
                _context.Add(libro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(libro);
        }

        // GET: Libroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libro = await _context.Libro.FindAsync(id);
            if (libro == null)
            {
                return NotFound();
            }
            return View(libro);
        }

        // POST: Libroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,isbn,titulo,autor,fecha,editorial,estado")] Libro libro)
        {
            if (id != libro.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(libro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LibroExists(libro.id))
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
            return View(libro);
        }

        // GET: Libroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libro = await _context.Libro
                .FirstOrDefaultAsync(m => m.id == id);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        // POST: Libroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var libro = await _context.Libro.FindAsync(id);
            _context.Libro.Remove(libro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LibroExists(int id)
        {
            return _context.Libro.Any(e => e.id == id);
        }
    }
}
