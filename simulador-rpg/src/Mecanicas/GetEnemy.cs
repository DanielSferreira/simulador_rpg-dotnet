using System;
using System.Collections.Generic;
using Entidades.Inimigos;
namespace Mecanicas
{
    public class GetEnemy
    {
        private Dictionary<int, Enemy> _listEnemy = new Dictionary<int, Enemy>();
        public List<Enemy> AllEnemys => new List<Enemy>(this._listEnemy.Values);

        public GetEnemy()
        {
            this._listEnemy.Add(1,new Bat());
            this._listEnemy.Add(2,new Slime());
            this._listEnemy.Add(3,new Rat());
            this._listEnemy.Add(4,new Skeleton());
            this._listEnemy.Add(5,new Orc1());
        }

        public Enemy GetEnemyByNumber(int index) 
        {
            return this._listEnemy[index];
        }
        public Enemy GetEnemyRandom() 
        {
            int indexRnd = (int) new Random().Next(1, this._listEnemy.Count);
            return this._listEnemy[indexRnd];
        }
    }
}