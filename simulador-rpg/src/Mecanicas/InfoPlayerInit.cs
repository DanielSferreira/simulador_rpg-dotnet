using System;
using Entidades;
namespace Mecanicas
{
    public class InfoPlayerInit
    {
        private string Name;
        private PlayerAttr Attr = new PlayerAttr();
        private string ClassName;

        public void InfoPlayerNameAndClassName(string name, string className)
        {
            this.Name = name;
            this.ClassName = className;
            this.setPlayerAttr();
        }

        public string getName(){
            Console.WriteLine(this.Name);
            return this.Name;
        }

        public string getClassName(){
            return this.ClassName;
        }
        public void setPlayerAttr()
        {
         Attr.PlayerName = this.Name;
         Attr.HpBase = 500;
         Attr.Mana   = 250;
         Attr.Atk    = 1250;
         Attr.Def    = 270;
         Attr.AtkM   = 100;
         Attr.DefM   = 50;
        }
        public PlayerAttr getPlayerAttr()
        {
            return this.Attr;
        }
    }
}