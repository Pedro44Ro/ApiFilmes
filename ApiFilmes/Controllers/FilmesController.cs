﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiFilmes.Data;
using ApiFilmes.Models;

namespace ApiFilmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly FilmesContext _context;

        public FilmesController(FilmesContext context)
        {
            _context = context;
        }

        // GET: api/Filmes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Filme>>> GetFilme()
        {
            return await _context.Filme.ToListAsync();
        }

        // GET: api/Filmes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Filme>> GetFilme(int id)
        {
            var filme = await _context.Filme.FindAsync(id);

            if (filme == null)
            {
                return NotFound();
            }

            return filme;
        }

        // PUT: api/Filmes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilme(int id, Filme filme)
        {
            if (id != filme.Id)
            {
                return BadRequest();
            }

            _context.Entry(filme).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmeExists(id))
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

        // POST: api/Filmes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Filme>> PostFilme(Filme filme)
        {
            _context.Filme.Add(filme);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilme", new { id = filme.Id }, filme);
        }

        // DELETE: api/Filmes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilme(int id)
        {
            var filme = await _context.Filme.FindAsync(id);
            if (filme == null)
            {
                return NotFound();
            }

            _context.Filme.Remove(filme);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FilmeExists(int id)
        {
            return _context.Filme.Any(e => e.Id == id);
        }
    }
}
