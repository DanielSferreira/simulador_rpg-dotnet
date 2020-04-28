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
            Console.WriteLine("Executando a Criação");
            this._player.Attr = player.getPlayerAttr();
            //this._player.Attr.PlayerName = "player.Name";
            this._player.ClassP = ClassType.getClassName( player.getClassName() );
            Console.WriteLine("Conclusão da Criação");
        }
        public void getPlayer()
        {
            Console.WriteLine($"O Jogador se chama {this._player.Attr.PlayerName}");
            //return _player;
        }
    }
}