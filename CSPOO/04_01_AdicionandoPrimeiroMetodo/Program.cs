using Contas;
namespace _04_01_AdicionandoPrimeiroMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            conta.Numero = "001";
            conta.DataAbertura = DateTime.Today;
            conta.Saldo = 150;
            conta.ExibirExtrato();
        }
    }
}