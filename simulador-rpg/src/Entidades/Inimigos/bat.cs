namespace Entidades.Inimigos
{
    public class Bat : Enemy
    {

        public Bat()
        {
            this.name = "Bat";
            this.hp = 250;
            this.ataque = 75;
            this.nivel = 1;
            this.xp = 35 + (this.xp *(this.nivel/3));
        }
    }
}