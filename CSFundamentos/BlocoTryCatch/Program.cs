namespace BlocoTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var nomes = new[] { "Marcelo", "Júlia", "Rafael" };
                for (var i = 0; i <= nomes.Length; i++)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
            catch (Exception excecao)
            {
                Console.WriteLine("Ocorreu um erro: " + excecao.Message);
                Console.WriteLine("Ocorreu um erro: " + excecao.StackTrace);
            }
        }
    }
}
// exececao.Message; -> retorna mensagem da exceção
// exececao.StackTrace; -> retorna onde a execeção foi lançanda (Namespace.Classe.Método in path)