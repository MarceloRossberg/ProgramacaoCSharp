namespace Contas
{
    public class Conta
    {
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
    }
}