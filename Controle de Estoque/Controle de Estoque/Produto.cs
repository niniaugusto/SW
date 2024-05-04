using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVideo
{
    class Produto
    {
        private int codigo;
        private string nome;
        private int estoque;
        private Double valor;

        public Produto(int codigo, string nome, int estoque, double valor)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.estoque = estoque;
            this.valor = valor;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCodigo()
        {
            return codigo;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getNome()
        {
            return nome;
        }
        public void setValor(Double valor)
        {
            this.valor = valor;
        }
        public Double getValor()
        {
            return valor;
        }

        public void entrada(int qtd)
        {
            estoque = estoque + qtd;
            Console.WriteLine("Entrada de " + qtd);
        }
        public void venda(int qtd)
        {
            estoque = estoque - qtd;
            Console.WriteLine("Venda de " + qtd);
        }
        public void imprimir()
        {
            Console.WriteLine("Dados do produto");
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Estoque: " + estoque);
            Console.WriteLine("Valor: " + valor);
        }
    }
}