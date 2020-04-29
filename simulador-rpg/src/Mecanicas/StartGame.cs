using System;
using System.Collections.Generic;
using Entidades.Classes;

namespace Mecanicas
{
    public class StartGame
    {
        public StartGame()
        {
            InitializateNewPlayer Ip = new InitializateNewPlayer();
            TowerBuilder Tb = new TowerBuilder();
            Tb.setPlayerInTower(Ip);
            
        }
    }
}
