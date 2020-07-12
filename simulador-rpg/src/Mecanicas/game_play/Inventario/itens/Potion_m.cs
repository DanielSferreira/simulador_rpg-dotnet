using Entidades;

namespace Mecanicas.game_play.Inventario.itens
{
    public class Potion_m : Item
    {
        public Potion_m()
        {
            this.name = "Poção média";
            this.value = 300;
        }
                
        public override void action(Player p) =>
            p.Attr.HpBase = p.Attr.HpBase + this.value;
            
        public void action(Player p, double newValue) =>
            p.Attr.HpBase = p.Attr.HpBase + newValue;
        
    }
}