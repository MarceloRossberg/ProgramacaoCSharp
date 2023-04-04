namespace Contas
{
    public class Conta
    {
        public static double TaxaRendimento = 0.5;
        public string Numero;
        public DateTime DataAbertura;
        public decimal Saldo;

        public string ExibirExtrato()
        {
            return $"Conta nº: {Numero}{Environment.NewLine}" +
                   $"Data da abertura: {DataAbertura.ToString("dd/MM/yyyy")}{Environment.NewLine}" +
                   $"Saldo: {Saldo.ToString("C")}{Environment.NewLine}" +
                   "---------------------------------------";
        }
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public void RealizarEmprestimo(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"O {valor} foi creditado e será debitado dentro de 30 dias.");
        }

        public void RealizarEmprestimo(decimal valor, int parcelas)
        {
            Saldo += valor;
            Console.WriteLine($"O {valor} foi creditado e será debitado em {parcelas} vezes.");
        }

        public static double CalcularRendimento(double capital, int meses)
        {
            return capital * Math.Pow(1 + TaxaRendimento, meses); // fórmula juros composto 1 + 0.5 ** meses
        }
    }
}