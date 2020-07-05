namespace simulador_rpg.src.Entidades.Inimigos
{
    public class bat
    {
        public string name = "Bat";
        public float hp { get; set; }
        public float ataque { get; set; }

        public bat()
        {
            this.hp = 250;
            this.ataque = 45;
        }
    }
}