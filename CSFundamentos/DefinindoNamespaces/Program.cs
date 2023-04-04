using Financeiro;
using RH;
using Orcamento;
namespace DefinindoNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaPagar = new ContaPagar();
            var contaReceber = new ContaReceber();
            var funcionario = new Funcionario();

            var folhaPagamento = new RH.FolhaPagamento();
            var folhaPagamentoFinanceiro = new Financeiro.FolhaPagamento();
        }
    }
}
