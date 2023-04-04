namespace EstuturaRepeticaoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new[] { "Marcelo", "Júlia", "Rafael" };
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}