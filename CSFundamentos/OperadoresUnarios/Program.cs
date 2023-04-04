namespace OperadoresUnarios
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 5;
            var c = 5;
            var d = 5;

            //  a++;  a = a + 1
            //  b--;  a = a - 1

            // Pós-fixado: incremento/decremento é feito após a instrução Console.WriteLine
            Console.WriteLine($"Pós incremento: {a++}");
            Console.WriteLine($"Pós decremento: {b--}");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");

            // Pré-fixado: incremento/decremento é feito primeiro que em seguida instrução Console.WriteLine
            Console.WriteLine($"Pré incremento: {++c}");
            Console.WriteLine($"Pré decremento: {--d}");
        }
    }
}