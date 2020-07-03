using System;
using Entidades;
using static Mecanicas.ClassType;
namespace Mecanicas
{
    public class NewPlayer: INewPlayer
    {
        private Player _player = new Player();
        
        public NewPlayer(InfoPlayerInit player)
        {
            this._player.Attr = player.getPlayerAttr();
            this._player.ClassP = ClassType.getClassName( player.getClassName() );
            Console.WriteLine("Conclusão da Criação");
        }
        
        public void getPlayerConsole()
        {
            Console.WriteLine($"O Jogador se chama {this._player.Attr.PlayerName}");
            //return _player;
        }
        
        public Player getPlayer()
        {
            return _player;
        }
    }
}