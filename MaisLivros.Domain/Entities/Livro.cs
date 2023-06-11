using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisLivros.Models
{
    public sealed class Livro
    {
        public String Edicao { get; set; }

        public String Idioma { get; set; }

        public String Autor { get; set; }

        public String Nome { get; set; }
    }
}
