using System;
using Entidades;
using Entidades.Inimigos;

namespace Mecanicas.levels
{
    public class LevelManagement
    {
        Player _p;
        double _xp_current;
        double _xp_for_next_level;
        int nivel;
        public LevelManagement(Player player)
        {
            _xp_for_next_level = 500;
            _p = player;
        }

        public void addXP(Enemy e)
        {
            Console.WriteLine($"\t xp atual: {_xp_current} xp que falta para o proximo nivel { _xp_for_next_level } e nivel atual { nivel }");
            //this._p.level._xp_current = this._p.level._xp_current + e.xp;
            _xp_current = _xp_current + e.xp;

           // if (_xp_current >= _xp_for_next_level) this.upLevel();
            if (_xp_current >= _xp_for_next_level) this.upLevel();
        }

        public void upLevel()
        {
            this._xp_current = 0;
            this._xp_for_next_level = this._xp_for_next_level + (this._xp_for_next_level * 1.15);
            this.nivel++;
            this.newAttr();
        }

        public void newAttr()
        {
            _p.Attr.Atk = _p.Attr.Atk * _p.ClassP.Atk_Base;
            _p.Attr.AtkM = _p.Attr.AtkM * _p.ClassP.AtkM_Base;
            _p.Attr.Def = _p.Attr.Def * _p.ClassP.Def_Base;
            _p.Attr.DefM = _p.Attr.DefM * _p.ClassP.DefM_Base;
            _p.Attr.HpBase = _p.Attr.HpBase * _p.ClassP.Hp_Base;
            _p.Attr.Mana = _p.Attr.Mana * _p.ClassP.Mana_Base;

        }
    }
}