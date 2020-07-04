using System;
using Entidades.Classes;
using Mecanicas;

namespace Entidades
{
    public class Player: INewPlayer
    {
        public IPlayerAttr Attr { get; set; }
        public IClassPlayer ClassP { get; set; }

    }
}