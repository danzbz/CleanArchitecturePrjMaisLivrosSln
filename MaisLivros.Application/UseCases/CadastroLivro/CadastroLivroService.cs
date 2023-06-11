using MaisLivros.Application.UseCases.DTO;
using MaisLivros.Domain.Interfaces;
using MaisLivros.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaisLivros.Application.UseCases.CadastroLivro
{
    class CadastroLivroService
    {
        private readonly ILivroRepository _livroRepository;

        public CadastroLivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public void CadastrarLivro(LivroDTO cadastroLivroDTO)
        {
            var livro = new Livro
            {
                Nome = cadastroLivroDTO.Nome,
                Autor = cadastroLivroDTO.Autor,
            };

            _livroRepository.AddLivro(livro);
        }
    }
}
