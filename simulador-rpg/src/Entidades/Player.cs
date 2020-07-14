using System;
using Entidades.Classes;
using Mecanicas;
using Mecanicas.levels;
using Mecanicas.game_play.Inventario;

namespace Entidades
{
    public class Player : INewPlayer
    {
        public IPlayerAttr Attr = new PlayerAttr();
        public IClassPlayer ClassP { get; set; }
        public LevelManagement level  { get; set; }
        public InitializeInvenctoryPlayer invenctoryPlayer = new InitializeInvenctoryPlayer();

        public Player()
        {
            level = new LevelManagement(this);
        }
    }
}