using System;

using Entidades.Classes;

namespace Entidades
{
    public class Player
    {
        public IPlayerAttr Attr { get; set; }
        public IClassPlayer ClassP { get; set; }
    }
}