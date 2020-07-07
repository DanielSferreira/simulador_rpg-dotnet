namespace Entidades.Inimigos
{
    public class Slime : Enemy
    {
        public string name = "Slime Azul";
        public float hp { get; set; }
        public float ataque { get; set; }

        public Slime()
        {
            this.hp = 350;
            this.ataque = 35;
        }
    }
}