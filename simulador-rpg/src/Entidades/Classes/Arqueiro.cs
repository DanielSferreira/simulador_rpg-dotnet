using System;

namespace Entidades.Classes
{
    public class Arqueiro: IClassPlayer
    {
        public Arqueiro()
        {
            Name_Base   = "Arqueiro";
            Hp_Base     = 1.03;
            Mana_Base   = 1.02;
            Atk_Base    = 1.03;
            Def_Base    = 1.05;
            AtkM_Base   = 1.02;
            DefM_Base   = 1.02;
        } 
    }
}