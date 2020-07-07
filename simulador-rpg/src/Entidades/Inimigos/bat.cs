namespace Entidades.Inimigos
{
    public class Bat : Enemy
    {
        public string name = "Bat";
        public float hp { get; set; }
        public float ataque { get; set; }

        public Bat()
        {
            this.hp = 250;
            this.ataque = 45;
        }
    }
}