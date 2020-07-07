using System.Collections.Generic;
using Entidades.Inimigos;
namespace Mecanicas
{
    public class GetEnemy
    {
        private Dictionary<int, Enemy> _listEnemy = new Dictionary<int, Enemy>();

        public GetEnemy()
        {
            this._listEnemy.Add(1,new Bat());
            this._listEnemy.Add(2,new Slime());
        }

        public Enemy GetEnemyByNumber(int index) 
        {
            return this._listEnemy[index-1];
        }
        public Enemy GetEnemyRandom() 
        {
            
            return this._listEnemy[0];
        }
    }
}