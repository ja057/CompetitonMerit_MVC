
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
    
    public class MeritlistsController : Controller
    {
        private readonly CompetitonMerit_MVCDB _context;

        public MeritlistsController(CompetitonMerit_MVCDB context)
        {
            _context = context;
        }

        // GET: Meritlists
        public async Task<IActionResult> Index()
        {
            var competitonMerit_MVCDB = _context.Meritlist.Include(m => m.School).Include(m => m.Student_participate).Include(m => m.Subject);
            return View(await competitonMerit_MVCDB.ToListAsync());
        }

        // GET: Meritlists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meritlist = await _context.Meritlist
                .Include(m => m.School)
                .Include(m => m.Student_participate)
                .Include(m => m.Subject)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meritlist == null)
            {
                return NotFound();
            }

            return View(meritlist);
        }
        [Authorize]
        // GET: Meritlists/Create
        public IActionResult Create()
        {
            ViewData["SchoolId"] = new SelectList(_context.School, "Id", "School_Address");
            ViewData["Student_participateId"] = new SelectList(_context.Student_participate, "Id", "Father_Name");
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Subject_Name");
            return View();
        }

        // POST: Meritlists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Student_participateId,SchoolId,SubjectId,Marks")] Meritlist meritlist)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meritlist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SchoolId"] = new SelectList(_context.School, "Id", "School_Address", meritlist.SchoolId);
            ViewData["Student_participateId"] = new SelectList(_context.Student_participate, "Id", "Father_Name", meritlist.Student_participateId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Subject_Name", meritlist.SubjectId);
            return View(meritlist);
        }
        [Authorize]
        // GET: Meritlists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meritlist = await _context.Meritlist.FindAsync(id);
            if (meritlist == null)
            {
                return NotFound();
            }
            ViewData["SchoolId"] = new SelectList(_context.School, "Id", "School_Address", meritlist.SchoolId);
            ViewData["Student_participateId"] = new SelectList(_context.Student_participate, "Id", "Father_Name", meritlist.Student_participateId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Subject_Name", meritlist.SubjectId);
            return View(meritlist);
        }

        // POST: Meritlists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Student_participateId,SchoolId,SubjectId,Marks")] Meritlist meritlist)
        {
            if (id != meritlist.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meritlist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeritlistExists(meritlist.Id))
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
            ViewData["SchoolId"] = new SelectList(_context.School, "Id", "School_Address", meritlist.SchoolId);
            ViewData["Student_participateId"] = new SelectList(_context.Student_participate, "Id", "Father_Name", meritlist.Student_participateId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Subject_Name", meritlist.SubjectId);
            return View(meritlist);
        }
        [Authorize]
        // GET: Meritlists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meritlist = await _context.Meritlist
                .Include(m => m.School)
                .Include(m => m.Student_participate)
                .Include(m => m.Subject)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meritlist == null)
            {
                return NotFound();
            }

            return View(meritlist);
        }

        // POST: Meritlists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meritlist = await _context.Meritlist.FindAsync(id);
            _context.Meritlist.Remove(meritlist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeritlistExists(int id)
        {
            return _context.Meritlist.Any(e => e.Id == id);
        }
    }
}
