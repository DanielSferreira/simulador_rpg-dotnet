using System;

namespace Entidades.Classes
{
    public class Guerreiro: IClassPlayer
    {
        public Guerreiro()
        {
            Name_Base   = "Guerreiro";
            Hp_Base     = 1.06;
            Mana_Base   = 1.03;
            Atk_Base    = 1.05;
            Def_Base    = 1.03;
            AtkM_Base   = 1.01;
            DefM_Base   = 1.01;
        } 
    }
}