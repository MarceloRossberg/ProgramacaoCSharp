namespace TrabalhandoComClasses
{
    class Aluno
    {
        public string Nome;
        public int Idade;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var aluno1 = new Aluno();
            aluno1.Nome = "Marcelo";
            aluno1.Idade = 34;

            Console.WriteLine(aluno1.Nome);
            Console.WriteLine(aluno1.Idade);

            var aluno2 = new Aluno();
            aluno2.Nome = "Júlia";
            aluno2.Idade = 30;

            Console.WriteLine(aluno2.Nome);
            Console.WriteLine(aluno2.Idade);
        }
    }
}