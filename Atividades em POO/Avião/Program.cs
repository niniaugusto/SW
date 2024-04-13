namespace Avião
{
    public class Program
    {
        static void Main(string[] args)
        {
            Avião avião1 = new Avião();
            Avião avião2 = new Avião();

            avião1.Acelerar();
            avião2.Reduzir();
            avião1.Subir();
            avião2.Descer();
            avião1.Gol1();
            avião2.Gol2();
            avião1.Mrc1();
            avião2.Mrc2();

            Console.WriteLine("A velocidade do primeiro avião está em constante: " + avião1.Velocidade);
            Console.WriteLine("A velocidade do segundo avião está em constante: " + avião2.Velocidade);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("A altitude do primeiro avião está em constante: " + avião1.Altitude);
            Console.WriteLine("A altitude do segundo avião está em constante: " + avião2.Altitude);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("O modelo do primeiro avião é: " + avião1.VerMod());
            Console.WriteLine("O modelo do segundo avião é: " + avião2.VerMod());
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("A marca do primeiro avião é: " + avião1.VerMrc());
            Console.WriteLine("A marca do segundo avião é: " + avião2.VerMrc());
        }
    }
}
