using System;
using Entidades;
using Entidades.Classes;
using static Mecanicas.ClassType;
namespace Mecanicas
{
    public class NewPlayer: INewPlayer
    {
        private Player _player = new Player();
        
        public NewPlayer(InfoPlayerInit player)
        {
            this._player.ClassP = ClassType.getClassName( player.getClassName() );
            this._player.Attr = AssignClassPlayer(player.getPlayerAttr(),this._player.ClassP);;
        }
        
        public void getPlayerConsole() => Console.WriteLine($"O Jogador se chama {this._player.Attr.PlayerName}");
        
        public Player getPlayer() => _player;
        

        public PlayerAttr AssignClassPlayer(PlayerAttr Attr, IClassPlayer class_player)
        {
            Attr.HpBase = Attr.HpBase * class_player.Hp_Base;
            Attr.Mana = Attr.Mana * class_player.Mana_Base;
            Attr.Atk = Attr.Atk * class_player.Atk_Base;
            Attr.Def = Attr.Def * class_player.Def_Base;
            Attr.AtkM = Attr.AtkM * class_player.AtkM_Base;
            Attr.DefM = Attr.DefM * class_player.DefM_Base;

            return Attr;
        }
    }
}