using System;
using Entidades;
namespace Mecanicas
{
    public class InfoPlayerInit
    {
        private string Name = "Abobora";
        private PlayerAttr Attr = new PlayerAttr();
        private string ClassName;

        public void InfoPlayerNameAndClassName(string name, string className)
        {
            Console.WriteLine("Definição dos atributos");
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
         Attr.Mana   = 100;
         Attr.Atk    = 15;
         Attr.Def    = 10;
         Attr.AtkM   = 10;
         Attr.DefM   = 5;
        }
        public PlayerAttr getPlayerAttr()
        {
            return this.Attr;
        }
    }
}