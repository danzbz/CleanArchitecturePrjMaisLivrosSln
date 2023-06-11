using System;
using System.Collections.Generic;
using System.Text;

namespace MaisLivros.Application.UseCases.CadastroLivro
{
    public class CadastroLivroResponse
    {
        public int LivroId { get; set; }
        public string Mensagem { get; set; }

        public CadastroLivroResponse(int livroId, string mensagem)
        {
            LivroId = livroId;
            Mensagem = mensagem;
        }
    }
}
