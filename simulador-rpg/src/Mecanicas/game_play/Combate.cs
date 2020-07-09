using System;
using Entidades;
using Entidades.Inimigos;
namespace Mecanicas.game_play
{

    public class Combate
    {
        private GetEnemy enemy1;
        private Enemy actual_enemy;
        private MenuCombat menu_c = new MenuCombat();
        private bool alternar_batle = false;
        public Combate(Player p)
        {
            this.actual_enemy = new GetEnemy().GetEnemyRandom();
            batle(p, actual_enemy);
        }

        public void batle(Player p, Enemy e)
        {
            Console.WriteLine($"{p.Attr.PlayerName} ao prosseguir no andar se depara com um {e.name}");
            Console.WriteLine("O que ele deve fazer?");
            int opt = this.menu_c.ShowOptions();
            string res = this.menu_c.ExecuteActions(opt);

            if (res == "ataque")
            {
                if (alternar_batle == true)
                    e.hp = (int)(e.hp - (p.Attr.Atk / 10));
                else
                    p.Attr.HpBase = p.Attr.HpBase - e.ataque / 10;
            }
            this.alternar_batle = !this.alternar_batle;
            if (p.Attr.HpBase > 0 || e.hp > 0) batle(p, e);
        }
    }
}