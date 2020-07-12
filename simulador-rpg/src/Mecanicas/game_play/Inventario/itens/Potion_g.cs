using Entidades;

namespace Mecanicas.game_play.Inventario.itens
{
    public class Potion_g : Item
    {
        public Potion_g()
        {
            this.name = "Poção grande";
            this.value = 500;
        }
                
        public override void action(Player p) =>
            p.Attr.HpBase = p.Attr.HpBase + this.value;
            
        public void action(Player p, double newValue) =>
            p.Attr.HpBase = p.Attr.HpBase + newValue;
        
    }
}