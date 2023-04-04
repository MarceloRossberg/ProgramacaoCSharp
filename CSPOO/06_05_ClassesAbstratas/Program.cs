using Personagens;
namespace _06_05_ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cavaleiro = new Cavaleiro("Aragorn", 100);
            cavaleiro.Atacar();
            cavaleiro.Defender();
            cavaleiro.AtacarEspecial();

            var arqueiro = new Arqueiro("Legolas", 100);
            arqueiro.Atacar();
            arqueiro.Defender();
            arqueiro.AtacarEspecial();

            var mago = new Mago("Gandalf", 100, 100);
            mago.Atacar();
            mago.Defender();
            mago.AtacarEspecial();
        }
    } 
}

/*
classes abstract: dizemos que a classe não é possível ser instanciada. Devido ser uma espicificação genérica ("veículo: classe abstrata Carro: classe específica)
métodos abstract: dizemos que não podemos invocar o método na classe pai porém somos obrigado a utilizar o método nas classes filhas
*/