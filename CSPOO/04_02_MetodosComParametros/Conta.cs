namespace Contas
{
    public class Conta
    {
        public string Numero;
        public DateTime DataAbertura;
        public decimal Saldo;

        public void ExibirExtrato()
        {
            Console.WriteLine($"Conta nº: {Numero}");
            Console.WriteLine($"Data da abertura: {DataAbertura.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Saldo: {Saldo.ToString("C")}");
            Console.WriteLine("---------------------------------------");
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