namespace PalavrasBreakEContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso do break
            var notas = new int[] { 6, 8, 5, 7, 9 };
            var soma = 0.0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 6)
                {
                    Console.WriteLine("Nenhuma nota pode ser inferior a 6.");
                    soma = 0;
                    break;
                }
                soma += notas[i];
            }
            var media = soma / notas.Length;
            Console.WriteLine("Média: " + media);

            // Uso do continue
            notas = new int[] { 6, 8, 5, 7, 9 };
            soma = 0.0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 6)
                {
                    Console.WriteLine($"A nota {notas[i]} será desconsiderada.");
                    continue;
                }
                soma += notas[i];
            }
            media = soma / notas.Length;
            Console.WriteLine("Média: " + media);
        }
    }
}