using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    public class Conta
    {
        private string? Num_conta { get; set; }
        private double Saldo { get; set; }
        private double Limite { get; set; }

        public void consulta_saldo()
        {
            Console.WriteLine("O saldo atual é de R$: " + Saldo);
        }
        public void depositar(double deposito)
        {
            Saldo += deposito;
            Console.WriteLine("Seu saldo após o depósito é de R$ " + Saldo);
            Console.WriteLine("Você pode sacar até R$" + (Saldo + Limite));
        }
        public void sacar(double saque)
        {
            if (saque <= 0)
            {
                Console.WriteLine("Valor de saque inválido.");
                return;
            }

            if (saque <= Saldo + Limite)
            {
                Saldo -= saque;
                Console.WriteLine("Seu saldo após o saque é de R$ " + Saldo);
            }
            
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void ajusta_limite(double valor)
        {
            Limite = valor;
            Console.WriteLine($"Seu limite agora é de R${Limite},00 e você pode sacar até " + (Limite + Saldo));
        }
    }
}
