using System;
using Entidades;
using Componentes.Torre;

namespace Mecanicas.game_play
{
    public class GamePlay
    {
        Player _player;
        Tower _tower;

        public void InitializeGameWith(Player player, Tower tower) 
        {
            _player = player;
            _tower = tower;
        }

        public void SubirUmAndar()
        {
            _tower.upFloors();
        }

        public void ShowActions()
        {
            new MenuGamePlay(_player,  _tower);
        }
        
    }
}