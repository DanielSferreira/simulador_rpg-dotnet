using System;

namespace Entidades.Classes
{
    public class Mago: IClassPlayer
    {
        public Mago()
        {
            Name_Base   = "Mago";
            Hp_Base     = 1.01;
            Mana_Base   = 1.06;
            Atk_Base    = 1.01;
            Def_Base    = 1.02;
            AtkM_Base   = 1.04;
            DefM_Base   = 1.05;
        } 
    }
}