using Componentes;
using Mecanicas.game_play;

namespace Mecanicas
{
    public class StartGame
    {
        public StartGame()
        {
            TowerBuilder Tb = new TowerBuilder();
            InitializateNewPlayer Ip = new InitializateNewPlayer();
            
            new GamePlay().InicializarJogo(Ip.getPlayer(),Tb.getTower());
        }

    }
}

/*
    GamePlay gamePlay = new GamePlay();
    gamePlay.InicializarJogo(Ip.getPlayer(),Tb.getTower());
*/