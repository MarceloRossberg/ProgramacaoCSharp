using Contas;
namespace _04_03_MetodosComRetorno
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            conta.Numero = "001";
            conta.DataAbertura = DateTime.Today;
            conta.Saldo = 100;

            Console.WriteLine(conta.ExibirExtrato());
            conta.Depositar(50);
            Console.WriteLine(conta.ExibirExtrato());

            conta.Sacar(50);
            Console.WriteLine(conta.ExibirExtrato());
        }
    }
}