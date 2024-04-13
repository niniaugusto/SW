using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta
    {
        private string? Num_conta { get; set; }
        private double Saldo { get; set; }
        private double Limite { get; set; }

        public void consulta_saldo()
        {
            Console.WriteLine("O seu saldo atual é de R$ " + Saldo); 
        }

        public void depositar(double valor) { 
            Saldo += valor;
        }
        public void sacar(double valor) {
           if (valor < Saldo)
            {
                Saldo -= valor;
            }
           else
            {
                Console.WriteLine("SALDO INSUFICIENTE");
            }
        }
        public void ajuste_limite(double valor) { 
        Limite = valor;
        }
    }
}
