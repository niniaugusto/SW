namespace CarroEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro("Pagani", "Huayra", "Cinza");

            Console.WriteLine($"Um novo carro {meuCarro.Marca} {meuCarro.Modelo} {meuCarro.Cor} foi criado.");

            meuCarro.Acelerar(50);
            meuCarro.Acelerar(30);
            meuCarro.Desacelerar(20);

            Console.ReadLine();

        }
    }
}
