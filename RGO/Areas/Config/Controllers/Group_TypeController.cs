using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RGO.Data;
using RGO.Models;

namespace RGO.Areas.Config.Controllers
{
    [Area("Config")]
    public class Group_TypeController : Controller
    {
 
        private readonly ApplicationDbContext _context;

        public Group_TypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Group_Type
        public async Task<IActionResult> Index()
        {
            return View(await _context.Group_Types.ToListAsync());
        }

        // GET: Group_Type/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var group_Type = await _context.Group_Types
                .FirstOrDefaultAsync(m => m.Id == id);
            if (group_Type == null)
            {
                return NotFound();
            }

            return View(group_Type);
        }

        // GET: Group_Type/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Group_Type/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Created_By,Created_Date,Updated_By,Updated_Date,Notes")] Group_Type group_Type)
        {
            if (ModelState.IsValid)
            {
                _context.Add(group_Type);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(group_Type);
        }

        // GET: Group_Type/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var group_Type = await _context.Group_Types.FindAsync(id);
            if (group_Type == null)
            {
                return NotFound();
            }
            return View(group_Type);
        }

        // POST: Group_Type/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Created_By,Created_Date,Updated_By,Updated_Date,Notes")] Group_Type group_Type)
        {
            if (id != group_Type.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(group_Type);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Group_TypeExists(group_Type.Id))
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
            return View(group_Type);
        }

        // GET: Group_Type/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var group_Type = await _context.Group_Types
                .FirstOrDefaultAsync(m => m.Id == id);
            if (group_Type == null)
            {
                return NotFound();
            }

            return View(group_Type);
        }

        // POST: Group_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var group_Type = await _context.Group_Types.FindAsync(id);
            if (group_Type != null)
            {
                _context.Group_Types.Remove(group_Type);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Group_TypeExists(int id)
        {
            return _context.Group_Types.Any(e => e.Id == id);
        }
    }
}
