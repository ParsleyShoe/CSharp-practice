﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEducationService.Data;
using WebEducationService.Models;

namespace WebEducationService.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase {
        private readonly EdDbContext _context;

        public ClassesController(EdDbContext context) {
            _context = context;
        }

        // GET: api/Classes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetClasses() {
            return await _context.Classes.ToListAsync();
        }

        // GET: api/Classes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Class>> GetClass(int id) {
            var @class = await _context.Classes.FindAsync(id);

            if (@class == null) {
                return NotFound();
            }

            return @class;
        }

        // PUT: api/Classes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClass(int id, Class @class) {
            if (id != @class.Id) {
                return BadRequest();
            }

            _context.Entry(@class).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!ClassExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Classes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Class>> PostClass(Class @class) {
            _context.Classes.Add(@class);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClass", new { id = @class.Id }, @class);
        }

        // DELETE: api/Classes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Class>> DeleteClass(int id) {
            var @class = await _context.Classes.FindAsync(id);
            if (@class == null) {
                return NotFound();
            }

            _context.Classes.Remove(@class);
            await _context.SaveChangesAsync();

            return @class;
        }

        private bool ClassExists(int id) {
            return _context.Classes.Any(e => e.Id == id);
        }
    }
}
