using Entidades;

namespace Mecanicas.game_play.Inventario.itens
{

    public class Item
    {
        
        public string name { get; set; }
        public double value { get; set; }
        
        public virtual void action(Player p)
        { }
    }
}