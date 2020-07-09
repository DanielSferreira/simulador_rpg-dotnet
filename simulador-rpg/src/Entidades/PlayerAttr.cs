using System;

namespace Entidades
{
    public class PlayerAttr : IPlayerAttr
    {
        public PlayerAttr()
        {
            HpBase = 500;
            Mana = 250;
            Atk = 350;
            Def = 300;
            AtkM = 200;
            DefM = 150;
        }
    }
}