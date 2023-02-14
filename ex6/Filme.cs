using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex6
{
    public class Filme
    {
        public string NomeFilme { get; set; }
        public string Categoria { get; set; }
        public string FilmeCompleto(string NomeFilme, string Categoria)
        {
            return $"Filme {NomeFilme}, Categoria {Categoria}";
        }
    }
}

