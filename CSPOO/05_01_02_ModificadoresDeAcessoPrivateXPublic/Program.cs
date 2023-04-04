using RH;
namespace _05_02_ModificadoresDeAcessoPrivateXPublic
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario();
            funcionario.Nome = "Marcelo";
            funcionario.CPF = "000.000.000-00";
        }
    }
}