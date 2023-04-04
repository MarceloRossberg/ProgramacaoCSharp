using Personagens;
namespace _06_04_SobrescrevendoMetodosDaClassePai
{
    class Program
    {
        static void Main(string[] args)
        {
            var cavaleiro = new Cavaleiro("Aragorn", 100);
            cavaleiro.Atacar();
            cavaleiro.Defender();

            var arqueiro = new Arqueiro("Legolas", 100);
            arqueiro.Atacar();
            arqueiro.Defender();

            var mago = new Mago("Gandalf", 100, 100);
            mago.Atacar();
            mago.Defender();
            
        }
    } 
}