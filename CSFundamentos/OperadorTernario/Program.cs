namespace OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            var mensagem = "";
            var idade = 15;
            var nota = 9;

            // if (idade >= 18)
            //     mensagem = "Maior de idade";
            // else
            //     mensagem = "Menor de idade";

            // VARIÁVEL = CONDIÇÃO ? VALOR SE VERDADEIRO : VALOR SE FALSO
            mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
            Console.WriteLine(mensagem);

            mensagem = nota > 7 ? "Aprovado" : "Reprovado";
            Console.WriteLine(mensagem);
        }
    }
}