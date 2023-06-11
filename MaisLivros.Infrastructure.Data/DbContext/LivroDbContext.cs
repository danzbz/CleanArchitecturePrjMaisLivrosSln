using MaisLivros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaisLivros.Infrastructure.Data.Context
{
    public class LivroDbContext : DbContext
    {
        public LivroDbContext(DbContextOptions<LivroDbContext>
            options)
            : base(options)
        {
        }
        public DbSet<Livro> Livro { get; set; }
    }
}
