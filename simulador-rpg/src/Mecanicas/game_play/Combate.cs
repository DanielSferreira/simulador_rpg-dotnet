using System;
using Entidades;
using Entidades.Inimigos;
namespace Mecanicas.game_play
{
    
    public class Combate
    {
        private GetEnemy enemy1;
        private Enemy actual_enemy;

        public Combate(Player player)
        {
            enemy1  = new GetEnemy();
            actual_enemy = enemy1.GetEnemyRandom();
            // Console.WriteLine($"Ao prosseguir na torre você se depara com {this.enemy1.name} e com hp de: {this.enemy1.hp}");
        }
        
    }
}