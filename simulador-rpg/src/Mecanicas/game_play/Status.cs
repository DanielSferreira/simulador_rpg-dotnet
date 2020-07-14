
using System;
using Entidades;

namespace Mecanicas.game_play
{
    public class Status
    {
        public Status(Player p)
        { 
            Console.WriteLine($"Nome: {p.Attr.PlayerName} - Classe: {p.ClassP.Name_Base}:");
            Console.WriteLine($"Saúde \t Hp: {p.Attr.HpBase} \t Mana: {p.Attr.HpBase} ");
            Console.WriteLine($"Físico \t Atk: {p.Attr.Atk} \t Def: {p.Attr.Def} ");
            Console.WriteLine($"Mágico \t Atk_m: {p.Attr.AtkM} \t Def_m: {p.Attr.DefM} ");
        }
    }
}