namespace simulador_rpg.src.Entidades.Inimigos
{
    public class slime
    {
        public string name = "Slime Azul";
        public float hp { get; set; }
        public float ataque { get; set; }

        public slime()
        {
            this.hp = 350;
            this.ataque = 35;
        }
    }
}