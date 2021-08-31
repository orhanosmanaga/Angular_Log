using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using logproje.Models;

namespace logproje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogtbsController : ControllerBase
    {
        private readonly testContext _context;

        public LogtbsController(testContext context)
        {
            _context = context;
        }

        // GET: api/Logtbs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Logtb>>> GetLogtbs()
        {
            return await _context.Logtbs.ToListAsync();
        }

        // GET: api/Logtbs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Logtb>> GetLogtb(int id)
        {
            var logtb = await _context.Logtbs.FindAsync(id);

            if (logtb == null)
            {
                return NotFound();
            }

            return logtb;
        }

        // PUT: api/Logtbs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLogtb(int id, Logtb logtb)
        {
            if (id != logtb.Int)
            {
                return BadRequest();
            }

            _context.Entry(logtb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LogtbExists(id))
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

        // POST: api/Logtbs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Logtb>> PostLogtb(Logtb logtb)
        {
            _context.Logtbs.Add(logtb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLogtb", new { id = logtb.Int }, logtb);
        }

        // DELETE: api/Logtbs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLogtb(int id)
        {
            var logtb = await _context.Logtbs.FindAsync(id);
            if (logtb == null)
            {
                return NotFound();
            }

            _context.Logtbs.Remove(logtb);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LogtbExists(int id)
        {
            return _context.Logtbs.Any(e => e.Int == id);
        }
    }
}
