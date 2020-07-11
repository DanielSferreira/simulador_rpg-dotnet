using Entidades;

namespace Mecanicas.game_play.Inventario.itens
{
    public class Potion_p : Item
    {
        public Potion_p()
        {
            this.name = "Poção pequena";
            this.value = 150;
        }
        public string name { get; set; }
        public double value { get; set; }
        
        public override void action(Player p) =>
            p.Attr.HpBase = p.Attr.HpBase + this.value;
            
        public void action(Player p, double newValue) =>
            p.Attr.HpBase = p.Attr.HpBase + newValue;
        
        public override void effect()
        { }
    }
}