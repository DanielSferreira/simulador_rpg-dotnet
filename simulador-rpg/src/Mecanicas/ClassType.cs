using System;
using System.Collections.Generic;
using Entidades.Classes;

namespace Mecanicas
{
    public static class ClassType
    {
        private static Dictionary<string, IClassPlayer> classType = new Dictionary<string, IClassPlayer>();
        
        private static void setTipo(){
            classType.Add("Soldado", new Guerreiro());
            classType.Add("Mago", new Mago());
            classType.Add("Arqueiro", new Arqueiro());
        }
        public static IClassPlayer getClassName(string className)
        {
            setTipo();
            try
            {
                return classType[className];
            }
            catch (System.Exception)
            {
                Console.WriteLine($"Como não foi achado uma classe com o nome de {className}, criaremos a uma nova Classe do tipo, Guerreiro");
                return new Guerreiro();
            }
        }
    }
}
