using System;

namespace Entidades.Classes
{
    public abstract class IClassPlayer
    {
        public string Name_Base { get; set; }
        public double Hp_Base { get; set; }
        public double Mana_Base { get; set; }
        public double Atk_Base { get; set; }
        public double Def_Base { get; set; }
        public double AtkM_Base { get; set; }
        public double DefM_Base { get; set; }

    }
}