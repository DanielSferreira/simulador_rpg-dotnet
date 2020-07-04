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
            Console.WriteLine($"O Nome do Jogador é {Ip.getPlayer().Attr.PlayerName}");
            Console.WriteLine($"A Classe do Jogador é {Ip.getPlayer().ClassP.Name_Base}");
            
        }
    }
}
