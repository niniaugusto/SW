namespace ExercicioVideo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(1, "Notebook", 0, 2300);
            p.imprimir();
            p.entrada(20);
            p.imprimir();
            p.venda(5);
            p.imprimir();
        }
    }
}