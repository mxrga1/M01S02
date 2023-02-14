
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2
{
    public class FichaInscricao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool MenorIdade { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine($"Código: {Id}, Nome: {Nome}, Data de Nascimento: {DataNascimento}");
        }
    }
}