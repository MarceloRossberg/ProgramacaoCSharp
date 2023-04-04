using RH;
namespace _05_05_EntendendoMetedoSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario("Marcelo", "000.000.000-00");
            funcionario.CPF = "111.111.111-11";
            Console.WriteLine(funcionario.CPF);
        }
    }
}