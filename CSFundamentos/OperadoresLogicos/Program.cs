namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // ! - Not(negação)
            var ativo = false;

            var a = 3;
            var b = 5;
            Console.WriteLine(!(a > b));

            // && - And(e)
            Console.WriteLine(ativo == true && a < b);

            // || - Or(ou)
            Console.WriteLine(ativo == true || a < b);
        }
    }
}