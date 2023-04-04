namespace TipoString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenação de string
            var nome = "Marcelo";
            var sobrenome = "Rossberg Palmieri";
            var nomeCompleto = nome + " " + sobrenome;
            Console.WriteLine("Concatenação: " + nomeCompleto);

            // Interpolação de string
            var nomeCompleto1 = $"{nome} {sobrenome}";
            Console.WriteLine($"Interporlação: {nomeCompleto1}");

            // Métodos string personalizados
            Console.WriteLine($"Texto para maiúsculo: {nomeCompleto.ToUpper()}");
            Console.WriteLine($"Texto para minúsculo: {nomeCompleto.ToLower()}");

            Console.WriteLine($"Método Substring(índice): {nomeCompleto.Substring(8)}");
            Console.WriteLine($"Método Substring(índice, tamanho): {nomeCompleto.Substring(8, 8)}");

            Console.WriteLine($"nomeCompleto contém 'R'? {nomeCompleto.Contains('R')}");
            Console.WriteLine($"nomeCompleto contém 'xyz'? {nomeCompleto.Contains("xyz")}");

            Console.WriteLine($"nomeCompleto começa com o char 'M'? {nomeCompleto.StartsWith('M')}");
            Console.WriteLine($"nomeCompleto termina com char 'L'? {nomeCompleto.EndsWith('L')}");

            Console.WriteLine($"Ocorrência do primeiro índice do char 'r'? {nomeCompleto.IndexOf('r')}");
            Console.WriteLine($"Última ocorrência do índice do char 'r'? {nomeCompleto.LastIndexOf('r')}");

            // .Substring(índice, tamanho); -> retorna parte da string partir do índice(index) 4 e conte 5 caracteres(length)
            // .Contains('letra'); -> retorna bool se string contém determinado char/string
            // .StartsWith('char'); -> retorna bool se string começa com char/string
            // .EndsWith('char'); -> retorna bool se string termina com char/string
            // .IndexOf('char'); -> retorna int(index) da primeira ocorrência de uma determinado char/string
            // .LastIndexOf('char'); -> retorna int(índice) da útima ocorrência de uma determinado char/string
        }
    }
}
