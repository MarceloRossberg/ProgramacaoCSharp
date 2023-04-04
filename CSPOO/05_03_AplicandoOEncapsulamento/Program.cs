using RH;
namespace _05_03_AplicandoOEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario("Marcelo", "000.000.000-00");
            Console.WriteLine(funcionario.GetCPF());
            funcionario.SetCPF("111-111-111-11");
            Console.WriteLine(funcionario.GetCPF());
        }
    }
}