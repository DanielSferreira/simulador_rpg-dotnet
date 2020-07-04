using System;
using System.Collections.Generic;
using Componentes;

namespace Mecanicas
{
    public class StartGame
    {
        public StartGame()
        {
            TowerBuilder Tb = new TowerBuilder();
            InitializateNewPlayer Ip = new InitializateNewPlayer();
            //Tb.setPlayerInTower(Ip);
            Console.WriteLine($"O Nome do Jogador é {Ip.getPlayer().Attr.PlayerName}");
            
        }
    }
}
