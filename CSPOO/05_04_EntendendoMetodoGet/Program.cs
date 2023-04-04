using RH;
namespace _05_04_EntendendoMetodoGet
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario("Marcelo", "000.000.000-00");
            Console.WriteLine(funcionario.CPF);
        }
    }
}