using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex5
{
    public class Cobrar
    {
        private decimal Valor;
        private decimal Multa;

         public Cobrar(decimal Valor, decimal Multa)
    {
        this.Valor = Valor;
        this.Multa = Multa;
    }

    private decimal CalcularMulta()
    {
        return Valor + Multa;
    }

    public void Calcular()
    {
        Console.WriteLine($"Valor Cobrado {Valor}, Multa {Multa}, Soma valor {CalcularMulta()}");
    }
    
        
    }
    
}