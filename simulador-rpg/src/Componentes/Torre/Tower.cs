using System;
using Entidades;

namespace Componentes.Torre
{
    public class Tower: ITower
    {
        public Tower()
        {
            this.nomeTorre = "Torre Infinita";
        }
        public void upFloors()
        {
            this.floors.next();
        }
        public void setPlayerInTower(Player player)
        {
            this.PlayerOfTower = player;
        }
    }  
}