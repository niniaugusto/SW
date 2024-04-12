namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Banco ETEC MCM");

            //Instanciar a classe Conta e criar um objeto dela
            Conta conta = new Conta();
            Console.WriteLine("Consultando saldo:");
            conta.consulta_saldo();
            Console.WriteLine("Depósito de R$1000.35:");
            conta.depositar(1000.35);
            Console.WriteLine("Consultando saldo:");
            conta.consulta_saldo();


            //Console.WriteLine("Saque de 500:");
            //conta.sacar(500);
            //Console.WriteLine("Consultando saldo:");
            //conta.consulta_saldo();

            //Console.WriteLine("Saque de 1000:");
            //conta.sacar(1000);

            conta.ajuste_limite(1000);
            conta.consulta_saldo();
            conta.sacar(2000);
            conta.consulta_saldo();

        }
    }
}