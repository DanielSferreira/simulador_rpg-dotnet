using System;
using Entidades.Classes;

namespace Entidades
{
    public abstract class IPlayerAttr
    {
        public string PlayerName { get; set; }
        public double HpBase { get; set; }
        public double Mana   { get; set; }
        public double Atk    { get; set; }
        public double Def    { get; set; }
        public double AtkM   { get; set; }
        public double DefM   { get; set; }
        
    }
}