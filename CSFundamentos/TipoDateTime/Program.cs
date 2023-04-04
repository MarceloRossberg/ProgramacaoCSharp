namespace TipoDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoje = DateTime.Today;
            var agora = DateTime.Now;
            var data1 = new DateTime(1989, 12, 29);
            var data2 = new DateTime(2023, 03, 26, 19, 10, 45);
            var data3 = DateTime.Parse("15/08/2022");
            var data4 = DateTime.Parse("15/08/2022 12:20:50");

            Console.WriteLine(hoje);
            Console.WriteLine(agora);
            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.WriteLine(data3);
            Console.WriteLine(data4);

            // DateTime.Today; -> retorna a data Dia/Mes/Ano sem (Horas, Min, Segundos)
            // DateTime.Now; -> retorna a data Dia/Mes/Ano com (Horas, Min, Segundos)
            // newDateTime(Ano, Mes, Dia); -> retorna a data personalizada referente objeto criado sem horas
            // newDateTime(Ano, Mes, Dia, Horas, Min, Segundos); -> retorna a data personalizada referente objeto criado com horas
            // DateTime.Parse("15/08/2022"); -> retorna casting de string para DateTime sem horas
            // DateTime.Parse("15/08/2022 12:20:50"); -> retorna casting de string para DateTime com horas

            // Métodos DateTime para exibir data/horas
            Console.WriteLine($"Dia da data: {data4.Day}");
            Console.WriteLine($"Mês da data: {data4.Month}");
            Console.WriteLine($"Ano da data: {data4.Year}");

            Console.WriteLine($"Horas da data: {data4.Hour}");
            Console.WriteLine($"Minutos da data: {data4.Minute}");
            Console.WriteLine($"Segundos da data: {data4.Second}");

            // Métodos DateTime para alterar data/horas
            Console.WriteLine($"Dia 15 + 5 dias: {data4.AddDays(5)}");
            Console.WriteLine($"Mês 08 - 1 mês: {data4.AddMonths(-1)}");

            // .AddDays(5); -> retorna soma da quantidade de dias de uma determinada data
            // .AddMonths(-1); -> retorna subtração de mêses de uma determinada data

            // Métodos DateTime para formatação
            Console.WriteLine($"Formatação por extenso da data: {data4.ToLongDateString()}");
            Console.WriteLine($"Formatação por extenso das horas: {data4.ToLongTimeString()}");

            // .ToLongDateString(); -> retorna formatação por extenso da data
            // .ToLongTimeString(); -> retorna formatação por extenso das horas

            Console.WriteLine($"Formatação por curta da data: {data4.ToShortDateString()}");
            Console.WriteLine($"Formatação por curta das horas: {data4.ToShortTimeString()}");

            // .ToShortDateString(); -> retorna formatação por curta da data
            // .ToShortTimeString(); -> retorna formatação por curta das horas










        }
    }
}