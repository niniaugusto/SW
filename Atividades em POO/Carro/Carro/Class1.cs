using System;

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public int Velocidade { get; private set; }

    public Carro(string marca, string modelo, string cor)
    {
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        Velocidade = 0;
    }

    public void Acelerar(int incremento)
    {
        Velocidade += incremento;
        Console.WriteLine($"O carro {Marca} {Modelo} acelerou para {Velocidade} km/h.");
    }

    public void Desacelerar(int decremento)
    {
        Velocidade -= decremento;
        if (Velocidade < 0)
            Velocidade = 0;
        Console.WriteLine($"O carro {Marca} {Modelo} desacelerou para {Velocidade} km/h.");
    }
}
