using System;
using Componentes.Torre;
using Entidades;

namespace Mecanicas
{
    public class TowerBuilder
    {
        private Tower T;

        public TowerBuilder()
        {
           this.T = new Tower();  
        }

        public void setPlayerForTower(Player player)
        {
            T.setPlayerInTower(player);
        }
        public Tower getTower()
        {
            return T;
        }
    }
}
