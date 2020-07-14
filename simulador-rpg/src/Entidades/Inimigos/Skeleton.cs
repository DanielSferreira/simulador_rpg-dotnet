namespace Entidades.Inimigos
{
    public class Skeleton : Enemy
    {

        public Skeleton()
        {
            this.name = "Skeleton";
            this.hp = 450;
            this.ataque = 150;
            this.nivel = 1;
            this.xp = 58 + (this.xp *(this.nivel/3));
        }
    }
}