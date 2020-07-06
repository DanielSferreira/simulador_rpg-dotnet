using System;
using Entidades;

namespace Componentes.Torre
{
    public class Tower: ITower
    {
        public Tower()
        {
            this.nomeTorre = "Torre Infinita";
            this.floors = new Floors();
        }
        public void upFloors()
        {
            this.floors.next();
            Console.WriteLine($"O Andar é {this.floors.getFloorName()}");
        }
        public void setPlayerInTower(Player player)
        {
            this.PlayerOfTower = player;
        }
    }  
}