namespace Entidades.Inimigos
{
    public class Slime : Enemy
    {

        public Slime()
        {
            this.name = "Slime Azul";
            this.hp = 350;
            this.ataque = 50;
            this.nivel = 1;
            this.xp = 42 + (this.xp *(this.nivel/3));
        }

        
    }
}