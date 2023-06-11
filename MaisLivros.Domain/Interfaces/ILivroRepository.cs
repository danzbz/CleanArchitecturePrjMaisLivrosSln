using MaisLivros.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaisLivros.Domain.Interfaces
{
    public interface ILivroRepository
    {
        IEnumerable<Livro> GetLivros();
    }
}
