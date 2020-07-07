using System;
using Entidades;
using Componentes.Torre;

namespace Mecanicas.game_play
{
    public class MenuGamePlay
    {
        public MenuGamePlay(Player player, Tower tower)
        {
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
            Console.WriteLine("Vamos lá!");
            Console.WriteLine("Agora tem Luta");
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