namespace EstruturaRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pecorrerendo um array com While
            var indice = 0;
            var arr1 = new[] { "1.0", "1.1", "2.0", "3.0" };
            while (indice < arr1.Length)
            {
                Console.Write(arr1[indice] + " ");
                indice++;
            }
        }
    }
}