using Itens;
namespace _08_04_PolimorfismoComInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // IColecionavel item1 = new Espada("Excalibur", 10, 10, 100);
            // item1.Colecionar();
            
            // IColecionavel itemColecionavel = new Joia("Diamante", 10, 10, 100);
            // itemColecionavel.Colecionar();
            // IConsumivel itemConsumivel = new Joia("Diamante", 10, 10, 100);
            // itemConsumivel.Consumir();

            var espada = new Espada("Excalibur", 10, 10, 100);
            var pocao = new Pocao("Poção de Vida", 20, 20, 50);
            var joia = new Joia("Diamante", 30, 30, 100);
            
            var itens = new List<Item>();
            itens.Add(espada);
            itens.Add(pocao);
            itens.Add(joia);
            
            foreach (var item in itens)
            {
                if (item is IColecionavel)
                {
                    (item as IColecionavel).Colecionar();
                }
                
                if (item is IConsumivel)
                {
                    (item as IConsumivel).Consumir();
                }
                if (item is Espada)
                {
                    Console.WriteLine((item as Espada).Dano);
                }
            }
        }
    }
}