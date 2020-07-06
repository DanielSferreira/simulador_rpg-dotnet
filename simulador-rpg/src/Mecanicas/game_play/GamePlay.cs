using System;
using Entidades;
using Componentes.Torre;

namespace Mecanicas.game_play
{
    public class GamePlay
    {
        Player _player;
        Tower _tower;

        public void InicializarJogo(Player player, Tower tower) 
        {
            _player = player;
            _tower = tower;
        }

        public void SubirUmAndar()
        {
            _tower.upFloors();
        }
        
    }
}