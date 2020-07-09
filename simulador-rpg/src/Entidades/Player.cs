using System;
using Entidades.Classes;
using Mecanicas;

namespace Entidades
{
    public class Player : INewPlayer
    {
        public IPlayerAttr Attr = new PlayerAttr();
        public IClassPlayer ClassP { get; set; }

        public Player()
        {
            Attr.HpBase = Attr.HpBase * ClassP.Hp_Base;
            Attr.HpBase = Attr.HpBase * ClassP.Hp_Base;
            Attr.Mana = Attr.Mana * ClassP.Mana_Base;
            Attr.Atk = Attr.Atk * ClassP.Atk_Base;
            Attr.Def = Attr.Def * ClassP.Def_Base;
            Attr.AtkM = Attr.AtkM * ClassP.AtkM_Base;
            Attr.DefM = Attr.DefM * ClassP.DefM_Base;
        }
    }
}