﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using prestamolibrosnet.Data;
using prestamolibrosnet.Models;

namespace prestamolibrosnet.Controllers
{
    [Authorize]
    public class PrestamoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrestamoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Prestamoes
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.FindFirst(ClaimTypes.Name).Value;
                ViewBag.userName = userName;
            }
            ViewBag.listaLibros = _context.Libro.ToList();
            ViewBag.calificacion = _context.Calificacion.ToList();
            return View(await _context.Prestamo.ToListAsync());
        }

        // GET: Prestamoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamo
                .FirstOrDefaultAsync(m => m.id == id);
            if (prestamo == null)
            {
                return NotFound();
            }

            return View(prestamo);
        }

        // GET: Prestamoes/Create
         public IActionResult Create(string myVar)
         {
            int id = Convert.ToInt16(myVar);
            ViewBag.libros = new SelectList(_context.Libro.Where(e => e.id == id), "id", "titulo");
            return View();
         }


        // POST: Prestamoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,idLibro")] Prestamo prestamo)
        {
            //prestamo.fechaDevolucion = DateTime.Today.AddDays(14);
            prestamo.fechaRealizado = DateTime.Today;

            if (User.Identity.IsAuthenticated)
            {
                var userName = User.FindFirst(ClaimTypes.Name).Value;
                prestamo.OwnerID = userName;
            }

            if (ModelState.IsValid)
            {
                _context.Add(prestamo);
                Libro libro = _context.Libro.Where(e => e.id == prestamo.idLibro).Single();
                libro.prestado = true;
                _context.Update(libro);
                await _context.SaveChangesAsync();

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("PrestamosLibros", "prestamolibrosucu@gmail.com"));
                message.To.Add(new MailboxAddress(libro.OwnerID));
                message.Subject = "Nueva solicitud de prestamo";
                message.Body = new TextPart("plain")
                {
                    Text = "Usted tiene una nueva solicitud de prestamo del libro: " + libro.titulo
                };
                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("prestamolibrosucu@gmail.com", "Ucu.1234");
                    client.Send(message);
                    client.Disconnect(true);
                }

                return RedirectToAction(nameof(Index));
            }

            return View(prestamo);
        }
        /*
        // GET: Prestamoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamo.FindAsync(id);
            if (prestamo == null)
            {
                return NotFound();
            }
            return View(prestamo);
        }

        // POST: Prestamoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,fechaRealizado,fechaDevolucion")] Prestamo prestamo)
        {
            if (id != prestamo.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prestamo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestamoExists(prestamo.id))
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
            return View(prestamo);
        }*/

        // GET: Prestamoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamo
                .FirstOrDefaultAsync(m => m.id == id);
            if (prestamo == null)
            {
                return NotFound();
            }

            return View(prestamo);
        }

        // POST: Prestamoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prestamo = await _context.Prestamo.FindAsync(id);
            _context.Prestamo.Remove(prestamo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrestamoExists(int id)
        {
            return _context.Prestamo.Any(e => e.id == id);
        }


        // GET: Prestamoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamo.FindAsync(id);
            if (prestamo == null)
            {
                return NotFound();
            }
            prestamo.fechaDevolucion = DateTime.Today;
            _context.Update(prestamo);
            Libro libro = _context.Libro.Where(e => e.id == prestamo.idLibro).Single();
            libro.prestado = false;
            _context.Update(libro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /*public IActionResult Devolver(Prestamo prestamo)
        {
            prestamo.fechaDevolucion = DateTime.Today;
            return View();
        }*/

        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Devolver(int id, [Bind("id,fechaRealizado,fechaDevolucion")] Prestamo prestamo)
        {
            if (id != prestamo.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                prestamo.fechaDevolucion = DateTime.Today;
                try
                {
                    _context.Update(prestamo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestamoExists(prestamo.id))
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
            return RedirectToAction(nameof(Index));
            //return View(prestamo);
        }*/
    }
}
