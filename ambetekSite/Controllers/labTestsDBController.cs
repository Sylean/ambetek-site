using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ambetekSite.Models;

namespace ambetekSite.Controllers
{
    public class labTestsDBController : Controller
    {
        private readonly labTestContext _context;

        public labTestsDBController(labTestContext context)
        {
            _context = context;    
        }

        // GET: labTestsDB
        public async Task<IActionResult> Index()
        {
            return View(await _context.labTest.ToListAsync());
        }

        // GET: labTestsDB/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var labTest = await _context.labTest
                .SingleOrDefaultAsync(m => m.ID == id);
            if (labTest == null)
            {
                return NotFound();
            }

            return View(labTest);
        }

        // GET: labTestsDB/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: labTestsDB/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,testCode,Description,Price,Category")] labTest labTest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(labTest);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(labTest);
        }

        // GET: labTestsDB/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var labTest = await _context.labTest.SingleOrDefaultAsync(m => m.ID == id);
            if (labTest == null)
            {
                return NotFound();
            }
            return View(labTest);
        }

        // POST: labTestsDB/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,testCode,Description,Price,Category")] labTest labTest)
        {
            if (id != labTest.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(labTest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!labTestExists(labTest.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(labTest);
        }

        // GET: labTestsDB/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var labTest = await _context.labTest
                .SingleOrDefaultAsync(m => m.ID == id);
            if (labTest == null)
            {
                return NotFound();
            }

            return View(labTest);
        }

        // POST: labTestsDB/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var labTest = await _context.labTest.SingleOrDefaultAsync(m => m.ID == id);
            _context.labTest.Remove(labTest);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public decimal returnPrice(int? id, string labCode)
        {
            IEnumerable<labTest> query =_context.labTest.Where(lab => lab.testCode == labCode);
            decimal queryPrice = query.FirstOrDefault()?.Price ?? 0;        
                return queryPrice;
        }
        public string returnDescription(int? id, string labCode)
        {
            IEnumerable<labTest> query = _context.labTest.Where(lab => lab.testCode == labCode);
            string queryDescription = query.FirstOrDefault()?.Description ?? "Not Found";
            return queryDescription;
        }

        private bool labTestExists(string id)
        {
            return _context.labTest.Any(e => e.ID == id);
        }
    }
}
