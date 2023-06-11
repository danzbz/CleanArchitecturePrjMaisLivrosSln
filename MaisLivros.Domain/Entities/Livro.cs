using MaisLivros.Domain.ValueObjects;
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

        public ISBN ISBN { get; set; }

        public Livro(string titulo, ISBN isbn)
        {
            Nome = titulo;
            ISBN = isbn ?? throw new ArgumentNullException(nameof(isbn), "ISBN não pode ser nulo.");
        }
    }
}
