namespace Entidades.Inimigos
{
    public class Orc1 : Enemy
    {

        public Orc1()
        {
            this.name = "Orc1";
            this.hp = 360;
            this.ataque = 175;
            this.nivel = 1;
            this.xp = 65 + (this.xp *(this.nivel/3));
        }
    }

}