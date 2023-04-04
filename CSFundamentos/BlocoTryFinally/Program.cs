namespace BlocoTryFinally
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
            }
            finally
            {
                Console.WriteLine("Programa encerrado");
            }
            /* 
            finally -> Para garantir que uma mensagem seja executado mesmo que tenha ocorrido uma exceção tratada ou não tratada. Sempré é utilizado em conjunto com o bloco catch.
            */
        }
    }
}