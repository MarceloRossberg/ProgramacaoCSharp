namespace OperadoresComparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 == 2);
            var a = 2;
            var b = 3;
            var iguais = a == b;
            var diferentes = a != b;
            var maior = a > b;
            var menor = a < b;
            var maiorOuIgual = a >= b;
            var menorOuIgual = a <= b;

            Console.WriteLine($"a == b: {a == b}");
            Console.WriteLine($"a == 2: {a == 2}");
            Console.WriteLine($"a == b: {iguais}");
            Console.WriteLine($"a != b: {diferentes}");
            Console.WriteLine($"a >= b: {maiorOuIgual}");
            Console.WriteLine($"a <= b: {menorOuIgual}");
        }
    }
}