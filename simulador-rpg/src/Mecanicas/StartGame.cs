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
            
            GamePlay gamePlay = new GamePlay();
            gamePlay.InitializeGameWith(Ip.getPlayer(),Tb.getTower());
            gamePlay.ShowActions();

        }

    }
}