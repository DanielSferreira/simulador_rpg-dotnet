using System;
using Entidades;
using Entidades.Inimigos;
namespace Mecanicas.game_play
{
    public class Combate
    {
        public Combate(Player p)
        {
            this._player = p;
            this._actual_enemy = new GetEnemy().GetEnemyRandom();
            Console.WriteLine($"{this._player.Attr.PlayerName} ao prosseguir no andar se depara com um {this._actual_enemy.name}");
            batle(this._player, this._actual_enemy);
        }

        private Player _player;
        private Enemy _actual_enemy;
        private bool alternar_batle = false;

        public void batle(Player p, Enemy e)
        {
            int opt =this.show_options();
            int factor = 5;
            
            if (opt == 1) this.atackerWithFactor(5);
            if (opt == 2) factor = this.defenderWithFactor((int)p.Attr.Def/10);
            if (opt == 3) this.invectory();
            if (opt == 4) Console.WriteLine("Você Arregou");
            if (opt == 4) return;

            Console.WriteLine($"Status da Luta: \n{p.Attr.PlayerName}: {p.Attr.HpBase} - {e.name}: {e.hp}");

            this._player.Attr.HpBase = this._player.Attr.HpBase - (this._actual_enemy.ataque / factor);
            
            
            if (e.hp <= 0)
            {
                Console.WriteLine($"{p.Attr.PlayerName} Venceu!!! Vamos prosseguir.");
                p.level.addXP(e);
            }
            else if (p.Attr.HpBase <= 0)
                Console.WriteLine("");
            else
                batle(p, e);
        }

        private int show_options()
        {
            Console.WriteLine("O que ele deve fazer?");
            return new MenuCombat().ShowOptions();
        }
        private void atackerWithFactor(int factor) =>
            this._actual_enemy.hp = this._actual_enemy.hp - (this._player.Attr.Atk / factor);
        
        private void invectory()
        {
             int choice = _player.invenctoryPlayer.showInvectory();
            _player.invenctoryPlayer._items2[choice].useItem(_player);
        }
        private int defenderWithFactor(int factor) => factor;
    }
}