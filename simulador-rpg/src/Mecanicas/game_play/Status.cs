
using System;
using Entidades;

namespace Mecanicas.game_play
{
    public class Status
    {
        public Status(Player p)
        { 
            Console.WriteLine($"\t \tStatus de \t {p.Attr.PlayerName}:");
            Console.WriteLine($"Infos \t Hp: {p.Attr.HpBase} \t Mana: {p.Attr.HpBase} ");
            Console.WriteLine($"Infos \t Atk: {p.Attr.Atk} \t Def: {p.Attr.Def} ");
            Console.WriteLine($"Infos \t Atk_m: {p.Attr.AtkM} \t Def_m: {p.Attr.DefM} ");
        }
    }
}