using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisLivros.Models
{
    public sealed class Livro
    {
        public Int32 CdLivro { get; set; }

        public Int32 CdUsuario { get; set; }

        public String TxEdicao { get; set; }

        public String TxIdioma { get; set; }

        public String TxAutor { get; set; }

        public String TxUrlFoto { get; set; }

        public String TxNome { get; set; }
    }
}
