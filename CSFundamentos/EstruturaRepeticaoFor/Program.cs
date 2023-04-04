namespace EstruturaRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new[] { 1, 10, 100, 1000 };
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            // for (var i = 0; i < 5; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // for (var i = 4; i >= 0; i--)
            // {
            //     Console.WriteLine(i);
            // }

            // for (var i = 5; i >= 0; i-=2)
            // {
            //     Console.WriteLine(i);
            // }
        }
    }
}