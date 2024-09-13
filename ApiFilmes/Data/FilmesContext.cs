using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiFilmes.Models;

namespace ApiFilmes.Data
{
    public class FilmesContext : DbContext
    {
        public FilmesContext (DbContextOptions<FilmesContext> options)
            : base(options)
        {
        }

        public DbSet<ApiFilmes.Models.Filme> Filme { get; set; } = default!;
    }
}
