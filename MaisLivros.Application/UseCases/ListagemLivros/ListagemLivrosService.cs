using MaisLivros.Application.UseCases.DTO;
using MaisLivros.Domain.Interfaces;
using MaisLivros.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaisLivros.Application.UseCases.ListagemLivros
{
    public class ListagemLivrosService
    {
        private readonly ILivroRepository _livroRepository;

        public ListagemLivrosService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public IEnumerable<LivroDTO> GetLivros()
        {
            var livros = _livroRepository.GetLivros();
            var livrosDTO = new List<LivroDTO>();

            foreach (var livro in livros)
            {
                var livroDTO = new LivroDTO
                {
                    Nome = livro.Nome,
                    Autor = livro.Autor,
                };

                livrosDTO.Add(livroDTO);
            }

            return livrosDTO;
        }
    }
}
