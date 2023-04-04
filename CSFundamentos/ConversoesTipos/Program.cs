namespace ConversoesTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversões implícitas: double = int
            int ano = 2020;
            double ano2 = ano;
            Console.WriteLine("Casting implícito: " + ano2);

            decimal taxa = 12.98m;
            // int taxa2 = taxa; // int = double error CS0103

            // Conversões explícitas
            int taxa2 = (int)taxa;
            Console.WriteLine("Casting explícito: " + taxa2);

            // Métodos string personalizados
            // ToString(); 
            string taxa3 = taxa.ToString();
            Console.WriteLine("toString(); " + taxa3);

            DateTime data = DateTime.Now;
            string data2 = data.ToString();
            Console.WriteLine("toString(); " + data2);

            // Parse();
            string resposta = "12";
            int idade = int.Parse(resposta);
            Console.WriteLine("Parse(resposta); " + idade);

            // Convert.ToInt32();
            string resposta1 = "23";
            int idade1 = Convert.ToInt32(resposta1);
            Console.Write("Convert.ToInt32(resposta1); " + resposta1);
        }
    }
}

// Conversões implícitas: aceitam conversões de forma automática pelo compilador sem perda de dados
// Conversões explícitas: assumimos o risco de conversões forçadas pelo compilador podendo ocorrer perda de dados
// Tipos de dados sem conversao: de decimal para string;

// Casting métodos personalizados strings:
// .toString(); -> casting (de tipos numéricos para string)
// .Parse(); -> casting (de tipos string para númericos)
// .Convert.ToInt32(); -> casting (de string para tipos númericos)