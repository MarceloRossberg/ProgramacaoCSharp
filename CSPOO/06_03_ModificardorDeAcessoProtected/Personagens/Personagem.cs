namespace Personagens
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        protected string Id {get; set;}
        public Personagem(string nome, int vida)
        {
            Nome = nome;
            Vida = vida;
        }
        public void Atacar()
        {
            Console.WriteLine($"{Nome} atacou.");
        }
        public void Defender()
        {
            Console.WriteLine($"{Nome} defendeu.");
        }
    }
}

/* 
Modificadores de acesso: public, private, protected
public: atributos e método visívies dentro e fora da classe.
private: atributo e método visíveis dentro da própria classe.
proctected: atributo e método vísiveis dentro da própria classe pai ou filho se tiver herença.
*/