using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaQuadradoRetangulo
{
    public class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int AreaCalculo { get; set; }

        public int Calcular()
        {
            AreaCalculo = Base * Altura;
            return AreaCalculo;
        }
        public string Calcular2()
        {
            string resultado = "";
            AreaCalculo = Base * Altura;

            if (Base == Altura)
            {
                resultado = "Quadrado: " + AreaCalculo;
            }
            else
            {
                resultado = "Retangulo: " + AreaCalculo;
            }

            return resultado;
        }

        public void MostraDetalhes()
        {
            Console.WriteLine("Base: " + Base);
            Console.WriteLine("Base: " + Altura);
            Console.WriteLine("Base: " + AreaCalculo);
        }

    }
}
