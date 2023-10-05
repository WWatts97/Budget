using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Budget.DATA.EF.Models;

namespace Budget.UI.MVC.Controllers
{
    public class UserEventsController : Controller
    {
        private readonly BudgetContext _context;

        public UserEventsController(BudgetContext context)
        {
            _context = context;
        }

        // GET: UserEvents
        public async Task<IActionResult> Index()
        {
            var budgetContext = _context.UserEvents.Include(u => u.Event).Include(u => u.User);
            return View(await budgetContext.ToListAsync());
        }

        // GET: UserEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.UserEvents == null)
            {
                return NotFound();
            }

            var userEvent = await _context.UserEvents
                .Include(u => u.Event)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserEventsId == id);
            if (userEvent == null)
            {
                return NotFound();
            }

            return View(userEvent);
        }

        // GET: UserEvents/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventName");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email");
            return View();
        }

        // POST: UserEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserEventsId,UserId,EventId")] UserEvent userEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventName", userEvent.EventId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", userEvent.UserId);
            return View(userEvent);
        }

        // GET: UserEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.UserEvents == null)
            {
                return NotFound();
            }

            var userEvent = await _context.UserEvents.FindAsync(id);
            if (userEvent == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventName", userEvent.EventId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", userEvent.UserId);
            return View(userEvent);
        }

        // POST: UserEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserEventsId,UserId,EventId")] UserEvent userEvent)
        {
            if (id != userEvent.UserEventsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserEventExists(userEvent.UserEventsId))
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
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventName", userEvent.EventId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", userEvent.UserId);
            return View(userEvent);
        }

        // GET: UserEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.UserEvents == null)
            {
                return NotFound();
            }

            var userEvent = await _context.UserEvents
                .Include(u => u.Event)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserEventsId == id);
            if (userEvent == null)
            {
                return NotFound();
            }

            return View(userEvent);
        }

        // POST: UserEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.UserEvents == null)
            {
                return Problem("Entity set 'BudgetContext.UserEvents'  is null.");
            }
            var userEvent = await _context.UserEvents.FindAsync(id);
            if (userEvent != null)
            {
                _context.UserEvents.Remove(userEvent);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserEventExists(int id)
        {
          return (_context.UserEvents?.Any(e => e.UserEventsId == id)).GetValueOrDefault();
        }
    }
}
