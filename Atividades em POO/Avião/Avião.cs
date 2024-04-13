using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avião
{
    public class Avião
    {
        private string? Modelo;
        public int Velocidade;
        public int Altitude;
        private string? Marca;

        public void Acelerar()
        {
            Velocidade = +1;
        }

        public void Reduzir()
        {
            Velocidade = -1;
        }

        public void Subir()
        {
            Altitude = +1;
        }

        public void Descer()
        {
            Altitude = -1;
        }

        public void Gol1()
        {
            Modelo = "737-8 MAX";
        }

        public void Gol2()
        {
            Modelo = "737-800 BCF";
        }

        public string VerMod()
        {
            return Modelo;
        }


        public void Mrc1()
        {
            Marca = "GOL";
        }

        public void Mrc2()
        {
            Marca = "FAP";
        }

        public string VerMrc()
        {
            return Marca;
        }

    }
}
