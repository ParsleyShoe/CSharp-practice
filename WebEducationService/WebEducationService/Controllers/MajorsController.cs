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
    public class MajorsController : ControllerBase {
        private readonly EdDbContext _context;

        public MajorsController(EdDbContext context) {
            _context = context;
        }

        // GET: api/Majors
        // async allows program to remain responsive to user while ... [Majors are retrieved]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Major>>> GetMajors() {
            return await _context.Majors.ToListAsync();
        }

        // GET: api/Majors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Major>> GetMajor(int id) {
            var major = await _context.Majors.FindAsync(id);

            if (major == null) {
                return NotFound();
            }

            return major;
        }

        // PUT: api/Majors/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMajor(int id, Major major) {
            if (id != major.Id) {
                return BadRequest();
            }

            _context.Entry(major).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!MajorExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Majors
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Major>> PostMajor(Major major) {
            _context.Majors.Add(major);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMajor", new { id = major.Id }, major);
        }

        // DELETE: api/Majors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Major>> DeleteMajor(int id) {
            var major = await _context.Majors.FindAsync(id);
            if (major == null) {
                return NotFound();
            }

            _context.Majors.Remove(major);
            await _context.SaveChangesAsync();

            return major;
        }

        private bool MajorExists(int id) {
            return _context.Majors.Any(e => e.Id == id);
        }
    }
}
