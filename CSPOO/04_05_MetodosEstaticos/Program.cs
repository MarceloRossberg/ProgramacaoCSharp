using Contas;
namespace _04_05_MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            conta.Numero = "001";
            conta.DataAbertura = DateTime.Today;
            conta.Saldo = 100;


            conta.RealizarEmprestimo(200, 10);
            Console.WriteLine(conta.ExibirExtrato());
            Console.WriteLine(Conta.TaxaRendimento);
            Console.WriteLine(Conta.CalcularRendimento(100, 12));
        }
    }
}