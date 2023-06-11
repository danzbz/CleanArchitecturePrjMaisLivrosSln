using System;
using System.Collections.Generic;
using System.Text;

namespace MaisLivros.Application.UseCases.CadastroLivro
{
    public class CadastroLivroRequest
    {
        public String Edicao { get; set; }

        public String Idioma { get; set; }

        public String Autor { get; set; }

        public String Nome { get; set; }
    }
}
