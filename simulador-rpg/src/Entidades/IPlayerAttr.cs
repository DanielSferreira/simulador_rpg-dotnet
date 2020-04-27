using System;
using Entidades.Classes;

namespace Entidades
{
    public abstract class IPlayerAttr
    {
        public string PlayerName { get; set; }
        public int HpBase { get; set; }
        public int Mana   { get; set; }
        public int Atk    { get; set; }
        public int Def    { get; set; }
        public int AtkM   { get; set; }
        public int DefM   { get; set; }
        
    }
}