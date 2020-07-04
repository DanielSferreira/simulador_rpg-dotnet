using System;
using Mecanicas;
using Entidades;
namespace Componentes
{
    public class InitializateNewPlayer
    {
        private Player _player;

        public InitializateNewPlayer()
        {
            Console.WriteLine("Criando Jogador \n ");
            var ply = new NewPlayer(this.InitializatePlayer());
            this._player = ply.getPlayer();
        }
        public InfoPlayerInit InitializatePlayer()
        {
            Console.WriteLine("Digite um Nome para seu Jogador:");
            string name = Console.ReadLine();
            Console.WriteLine("Agora escolha uma classe para ele:");
            Console.WriteLine("1 - Guerreiro: (os outro não vou colocar agora)");
            string className = Console.ReadLine();

            InfoPlayerInit newPlayerInit = new InfoPlayerInit();
            newPlayerInit.InfoPlayerNameAndClassName(name,className);
            return newPlayerInit;
        }

        public Player getPlayer()
        {
            return _player;
        }
    }
}