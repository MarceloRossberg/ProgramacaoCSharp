namespace Personagens
{
    public class Arqueiro : Personagem
    {
        public Arqueiro(string nome, int vida) : base(nome, vida)
        {
        }
        public override void Atacar()
        {
            Console.WriteLine($"{Nome} atacou com arco e flecha.");
        }
        public override void AtacarEspecial()
        {
            Console.WriteLine($"{Nome} Ataque especial com arco e flecha");
        }
    }
}
