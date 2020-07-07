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

        public void ShowActions() =>
            //Obs: passei essas referencias para manipular o combate a partir do menu
            new MenuGamePlay(_player, _tower);
    }
}