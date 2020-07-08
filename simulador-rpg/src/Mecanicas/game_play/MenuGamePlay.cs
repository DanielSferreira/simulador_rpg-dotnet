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
        public MenuGamePlay(Player player, Tower tower)
        {
            play_tower.player = player;
            play_tower.tower = tower;
            bool ContinueClimbing = true;
            OptionsMenu opt = new OptionsMenu();
            while (ContinueClimbing)
            {
                opt.ShowOptions();
                ContinueClimbing = this.option(opt.getOption());
            }
        }

        private bool option(int opt)
        {
            switch (opt)
            {
                case 1:
                    this.NextBatlle();
                    break;
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
        private void NextBatlle()
        {
            var algo = new Combate(this.play_tower.player);
        }
        private void Status()
        {
            Console.WriteLine("Status");
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