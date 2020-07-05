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

            Console.WriteLine($"Jogo Inializado com Jogador: {_player.Attr.PlayerName} lutando para sair da {_tower.nomeTorre}");
        }
        
    }
}