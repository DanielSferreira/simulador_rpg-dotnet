using System;
using Entidades;

namespace Componentes.Torre
{
    public class Tower: ITower
    {
        public Tower()
        {
            this.nomeTorre = "Torre Infinita";
            this.floor = new FloorTower();
        }
        public void setPlayerInTower(Player player)
        {
            this.PlayerOfTower = player;
        }
    }  
}