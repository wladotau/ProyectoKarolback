using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoKarol.Models;

namespace ProyectoKarol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatilloesController : ControllerBase
    {
        private readonly ProyectoRestKarolContext _context;

        public PlatilloesController(ProyectoRestKarolContext context)
        {
            _context = context;
        }

        // GET: api/Platilloes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Platillo>>> GetPlatillos()
        {
            return await _context.Platillos.ToListAsync();
        }

        // GET: api/Platilloes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Platillo>> GetPlatillo(int id)
        {
            var platillo = await _context.Platillos.FindAsync(id);

            if (platillo == null)
            {
                return NotFound();
            }

            return platillo;
        }

        // PUT: api/Platilloes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlatillo(int id, Platillo platillo)
        {
            if (id != platillo.IdPlatillo)
            {
                return BadRequest();
            }

            _context.Entry(platillo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlatilloExists(id))
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

        // POST: api/Platilloes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Platillo>> PostPlatillo(Platillo platillo)
        {
            _context.Platillos.Add(platillo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlatillo", new { id = platillo.IdPlatillo }, platillo);
        }

        // DELETE: api/Platilloes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlatillo(int id)
        {
            var platillo = await _context.Platillos.FindAsync(id);
            if (platillo == null)
            {
                return NotFound();
            }

            _context.Platillos.Remove(platillo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlatilloExists(int id)
        {
            return _context.Platillos.Any(e => e.IdPlatillo == id);
        }
    }
}
