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
    public class ProductPackagingsController : ControllerBase
    {
        private readonly WarehouseContext _context;

        public ProductPackagingsController(WarehouseContext context)
        {
            _context = context;
        }

        // GET: api/ProductPackagings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductPackaging>>> GetProductPackagings()
        {
            return await _context.ProductPackagings.ToListAsync();
        }

        // GET: api/ProductPackagings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductPackaging>> GetProductPackaging(int id)
        {
            var productPackaging = await _context.ProductPackagings.FindAsync(id);

            if (productPackaging == null)
            {
                return NotFound();
            }

            return productPackaging;
        }

        // PUT: api/ProductPackagings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductPackaging(int id, ProductPackaging productPackaging)
        {
            if (id != productPackaging.Id)
            {
                return BadRequest();
            }

            _context.Entry(productPackaging).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductPackagingExists(id))
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

        // POST: api/ProductPackagings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductPackaging>> PostProductPackaging(ProductPackaging productPackaging)
        {
            _context.ProductPackagings.Add(productPackaging);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductPackaging", new { id = productPackaging.Id }, productPackaging);
        }

        // DELETE: api/ProductPackagings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductPackaging(int id)
        {
            var productPackaging = await _context.ProductPackagings.FindAsync(id);
            if (productPackaging == null)
            {
                return NotFound();
            }

            _context.ProductPackagings.Remove(productPackaging);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductPackagingExists(int id)
        {
            return _context.ProductPackagings.Any(e => e.Id == id);
        }
    }
}
