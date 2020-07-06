using System;
using System.Collections.Generic;
using Entidades;
namespace Componentes.Torre
{
    public abstract class ITower
    {
        protected Floors floors {get; set;}
        protected string nomeTorre {get; set;}
        protected Player PlayerOfTower {get; set;}
        
    }  
}