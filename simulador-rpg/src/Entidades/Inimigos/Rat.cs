namespace Entidades.Inimigos
{
    public class Rat : Enemy
    {

        public Rat()
        {
            this.name = "Rat";
            this.hp = 255;
            this.ataque = 65;
            this.nivel = 1;
            this.xp = 25 + (this.xp *(this.nivel/3));
        }
    }
    
}