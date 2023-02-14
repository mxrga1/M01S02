using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3
{
    public class MensagemCelular
    {
        public int Telefone { get; set; }
        public string Mensagem { get; set; }

        public void Executar()
        {
            Console.WriteLine("Método Executado pelo Console");
            EnviarMensagemAoTelefone();
        }

        private void EnviarMensagemAoTelefone()
        {
            Console.WriteLine($"Telefone {Telefone}, Mensagem {Mensagem}");
        }
    }
}