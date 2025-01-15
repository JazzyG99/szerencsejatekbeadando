using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;
using TestApi.Data;

namespace TestApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class HuzasController : ControllerBase
    {
        private readonly TestApiContext _context;

        public HuzasController(TestApiContext context)
        {
            _context = context;
        }

        // GET: api/Huzas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Huzas>>> GetHuzas()
        {
            return await _context.Huzas.ToListAsync();
        }

        // GET: api/Huzas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Huzas>> GetHuzas(int id)
        {
            var huzas = await _context.Huzas.FindAsync(id);

            if (huzas == null)
            {
                return NotFound();
            }

            return huzas;
        }

        // PUT: api/Huzas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHuzas(int id, Huzas huzas)
        {
            if (id != huzas.Id)
            {
                return BadRequest();
            }

            _context.Entry(huzas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HuzasExists(id))
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

        // POST: api/Huzas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Huzas>> PostHuzas(Huzas huzas)
        {
            _context.Huzas.Add(huzas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHuzas", new { id = huzas.Id }, huzas);
        }

        // DELETE: api/Huzas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHuzas(int id)
        {
            var huzas = await _context.Huzas.FindAsync(id);
            if (huzas == null)
            {
                return NotFound();
            }

            _context.Huzas.Remove(huzas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HuzasExists(int id)
        {
            return _context.Huzas.Any(e => e.Id == id);
        }
    }
}
