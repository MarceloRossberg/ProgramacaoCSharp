namespace Itens
{
    class Joia : Item, IColecionavel, IConsumivel
    {
        public int Valor{get; set;}
        public Joia(string nome, int x, int y, int valor) : base(nome, x, y)
        {
            Valor = valor;
        }

        public void Colecionar()
        {
            Console.WriteLine("Jóia consumida.");
        }

        public void Consumir()
        {
            Console.WriteLine("Jóia coletada.");
        }
    }
}