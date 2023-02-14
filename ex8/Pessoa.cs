using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex8
{
    public class Pessoa
    {

        private string Nome { get; set; }

        private DateTime DataNascimento { get; set; }

        public void MostrarIdade()
        { 
            Nome = "Vinicius Margarida";
            int idade = CalcularIdade();
            Console.WriteLine($"Nome: {Nome} tem a idade {idade}");
        }
        public int CalcularIdade()
        {
            var dataNascimento = new DateTime(1999, 01, 25);
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }
    }




}