namespace EntradaSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome);
        }
    }
}
// Console.Read(); -> lê o primeiro caracter digitado e retorna o código decimal desse caracter
// Console.ReadKey() -> lê qualquer caracter digitado e retorna um objeto complexo