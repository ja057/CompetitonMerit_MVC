using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CompetitonMerit_MVC.Data;
using CompetitonMerit_MVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace CompetitonMerit_MVC.Controllers
{
    
    public class Student_participateController : Controller
    {
        private readonly CompetitonMerit_MVCDB _context;

        public Student_participateController(CompetitonMerit_MVCDB context)
        {
            _context = context;
        }

        // GET: Student_participate
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student_participate.ToListAsync());
        }

        // GET: Student_participate/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student_participate = await _context.Student_participate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student_participate == null)
            {
                return NotFound();
            }

            return View(student_participate);
        }
        [Authorize]
        // GET: Student_participate/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student_participate/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Student_Name,Student_age,Mobile_Number,Student_Address,Father_Name")] Student_participate student_participate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student_participate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student_participate);
        }
        [Authorize]
        // GET: Student_participate/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student_participate = await _context.Student_participate.FindAsync(id);
            if (student_participate == null)
            {
                return NotFound();
            }
            return View(student_participate);
        }

        // POST: Student_participate/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Student_Name,Student_age,Mobile_Number,Student_Address,Father_Name")] Student_participate student_participate)
        {
            if (id != student_participate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student_participate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Student_participateExists(student_participate.Id))
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
            return View(student_participate);
        }
        [Authorize]
        // GET: Student_participate/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student_participate = await _context.Student_participate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student_participate == null)
            {
                return NotFound();
            }

            return View(student_participate);
        }

        // POST: Student_participate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student_participate = await _context.Student_participate.FindAsync(id);
            _context.Student_participate.Remove(student_participate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Student_participateExists(int id)
        {
            return _context.Student_participate.Any(e => e.Id == id);
        }
    }
}
