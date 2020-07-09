using System;
using Entidades;
using Componentes.Torre;

namespace Mecanicas.game_play

{
    public struct Player_and_Tower_struct
    {
        public Player player;
        public Tower tower;

    }

    public class MenuGamePlay
    {
        public Player_and_Tower_struct play_tower;
        bool ContinueClimbing = true;

        public MenuGamePlay(Player player, Tower tower)
        {
            play_tower.player = player;
            play_tower.tower = tower;
            OptionsMenu opt = new OptionsMenu();
            
            while (this.ContinueClimbing)
            {
                if (this.check_player_status() == true)
                {
                    opt.ShowOptions();
                    this.ContinueClimbing = this.option(opt.getOption());
                }
                else 
                {
                    this.ContinueClimbing = false;
                }
            }
        }

        private bool check_player_status()
        {
            if (this.play_tower.player.Attr.HpBase <= 0)
            {
                Console.WriteLine($"{this.play_tower.player.Attr.PlayerName} perdeu totalmente seu HP morrendo ao subir a torre");
                Console.WriteLine("Game Over!");
                return false;
            }
            return true;
        }

        private bool option(int opt)
        {
            switch (opt)
            {
                case 1:
                    return this.NextBatlle();
                case 2:
                    this.Status();
                    break;
                case 3:
                    this.MenuItens();
                    break;
                case 4:
                    this.Loser();
                    return false;
            }
            return true;

        }
        private bool NextBatlle()
        {

            new Combate(this.play_tower.player);
            return true;
        }
        private void Status()
        {
            Console.WriteLine("Status:");
            Console.WriteLine("Tá tudo certo!");
        }
        private void MenuItens()
        {
            Console.WriteLine("Aqui o seus Itens");
        }
        private void Loser()
        {
            Console.WriteLine("Deu, vou meter o pé");
        }
    }
}