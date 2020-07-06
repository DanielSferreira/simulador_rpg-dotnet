using Componentes.Torre;

using System.Collections.Generic;

namespace Componentes.Torre
{
    public class Floors
    {
        private List<FloorTower> _floors = new List<FloorTower>();
        private int index;

        public FloorTower next()
        {
            index++;
            this._floors.Add(new FloorTower($"Andar {index}", index));
            return this._floors[index];
        }
        
        public FloorTower prev()
        {
            index--;
            return this._floors[index];
        }

    }
}