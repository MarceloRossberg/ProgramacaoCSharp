namespace DepurarCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = Console.ReadLine();
            Console.Write($"Olá, {nome}");
        }
    }
}
// breakpoint -> ponto de entrada/parada da aplicação
// step over ou f5 -> seguir linha a linha a depuração
// .vscode/launch.json/console -> caso necessitar depurar entrada de dados do usuário utilizar integratedTerminal