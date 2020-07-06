using Componentes.Torre;

using System.Collections.Generic;

namespace Componentes.Torre
{
    public class Floors
    {
        private List<FloorTower> _floors = new List<FloorTower>();
        private int index = 0;

        public FloorTower next()
        {
            this.index++;
            this._floors.Add(new FloorTower($"Andar {this.index}", this.index));
            return this._floors[this.index-1];
        }

        public FloorTower prev()
        {
            this.index--;
            return this._floors[this.index-1];
        }

        public string getFloorName()
        {
            return this._floors[this.index-1].getFloorName();
        }

    }
}