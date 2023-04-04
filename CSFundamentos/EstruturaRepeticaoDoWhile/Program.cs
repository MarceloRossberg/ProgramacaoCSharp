namespace EstruturaRepeticaoDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcao = "";
            do
            {
                Console.WriteLine("Digite uma opção: ");
                Console.WriteLine("1 - Saque | 2 - Depósito | 3 - Saldo | 0 - Sair");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Saquel realizado.");
                        break;
                    case "2":
                        Console.WriteLine("Depósito.");
                        break;
                    case "3":
                        Console.WriteLine("Saldo disponível: 100,00");
                        break;
                }
            } while (opcao != "0");
        }
    }
}