using MaisLivros.Domain.Interfaces;
using MaisLivros.Infrastructure.Data.Context;
using MaisLivros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MaisLivros.Infrastructure.Data.Repository
{
    public class LivroRepository : ILivroRepository
    {

        private LivroDbContext _context;

        public IEnumerable<Livro> GetLivros()
        {
            return _context.Livro;
        }

    }
}
