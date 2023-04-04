namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];
            numeros[0] = 10;
            numeros[1] = 11;
            numeros[2] = 12;

            // Formas de inicializar/declarar um array
            int[] pares = new int[3] { 2, 4, 6 };

            int[] impares = new int[] { 1, 3, 5, 7 };

            string[] nomes = new[] { "João", "Pedro", "Marta" };

            string[] paises = { "Brasil", "Argentina", "Portugal" };

            var cidades = new[] { "São Paulo", "Rio de Janeiro" };
            Console.WriteLine(cidades[0]);
            Console.WriteLine(cidades[1]);
        }
    }
}