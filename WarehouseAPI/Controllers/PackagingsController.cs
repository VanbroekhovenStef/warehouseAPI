using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Warehouse.DAL.Data;
using Warehouse.DAL.Models;

namespace WarehouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagingsController : ControllerBase
    {
        private readonly WarehouseContext _context;

        public PackagingsController(WarehouseContext context)
        {
            _context = context;
        }

        // GET: api/Packagings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Packaging>>> GetPackagings()
        {
            return await _context.Packagings.ToListAsync();
        }

        // GET: api/Packagings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Packaging>> GetPackaging(int id)
        {
            var packaging = await _context.Packagings.FindAsync(id);

            if (packaging == null)
            {
                return NotFound();
            }

            return packaging;
        }

        // PUT: api/Packagings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPackaging(int id, Packaging packaging)
        {
            Packaging packaging1 = new Packaging()
            {
                Id = id,
                Type = packaging.Type,
                Weight = packaging.Weight
            };

            if (id != packaging1.Id)
            {
                return BadRequest();
            }

            _context.Entry(packaging1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PackagingExists(id))
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

        // POST: api/Packagings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Packaging>> PostPackaging(Packaging packaging)
        {
            _context.Packagings.Add(packaging);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPackaging", new { id = packaging.Id }, packaging);
        }

        // DELETE: api/Packagings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePackaging(int id)
        {
            var packaging = await _context.Packagings.FindAsync(id);
            if (packaging == null)
            {
                return NotFound();
            }

            _context.Packagings.Remove(packaging);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PackagingExists(int id)
        {
            return _context.Packagings.Any(e => e.Id == id);
        }
    }
}
