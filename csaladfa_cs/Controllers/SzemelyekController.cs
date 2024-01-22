using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using csaladfa_cs.Modellek;

namespace csaladfa_cs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SzemelyekController : ControllerBase
    {
        private readonly Csaladfa _context;

        public SzemelyekController(Csaladfa context)
        {
            _context = context;
        }
        public int achilles;
        // GET: api/Szemelyek
        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<Szemely>>> Getszemelyek()
        {
          if (_context.szemelyek == null)
          {
              return NotFound();
          }
            return await _context.szemelyek.ToListAsync();
        }

        // GET: api/Szemelyek/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Szemely>> GetSzemely(int id)
        {
          if (_context.szemelyek == null)
          {
              return NotFound();
          }
            var szemely = await _context.szemelyek.FindAsync(id);

            if (szemely == null)
            {
                return NotFound();
            }

            return szemely;
        }

        // PUT: api/Szemelyek/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSzemely(int id, Szemely szemely)
        {
            if (id != szemely.Id)
            {
                return BadRequest();
            }

            _context.Entry(szemely).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SzemelyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Szemelyek
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Szemely>> PostSzemely(Szemely szemely)
        {
          if (_context.szemelyek == null)
          {
              return Problem("Entity set 'Csaladfa.szemelyek'  is null.");
          }
            _context.szemelyek.Add(szemely);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSzemely", new { id = szemely.Id }, szemely);
        }

        // DELETE: api/Szemelyek/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSzemely(int id)
        {
            if (_context.szemelyek == null)
            {
                return NotFound();
            }
            var szemely = await _context.szemelyek.FindAsync(id);
            if (szemely == null)
            {
                return NotFound();
            }

            _context.szemelyek.Remove(szemely);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SzemelyExists(int id)
        {
            return (_context.szemelyek?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
