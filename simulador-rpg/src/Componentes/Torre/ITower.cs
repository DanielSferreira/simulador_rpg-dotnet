using System;
using Entidades;
namespace Componentes.Torre
{
    public abstract class ITower
    {
        public FloorTower floor {get; set;}
        public string nomeTorre {get; set;}
        public Player PlayerOfTower {get; set;}
        
    }  
}