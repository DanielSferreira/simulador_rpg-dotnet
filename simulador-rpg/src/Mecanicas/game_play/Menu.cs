using System;
using Entidades.Classes;
using Mecanicas;
namespace Mecanicas.game_play
{
    public class Menu
    {
        public Menu()
        {
            var options = new OptionsMenu();
            this.option(options.getOption());
        }
        private void option(int opt)
        {
            switch (opt)
            {
                case 1:
                    this.novoJogo();
                    return;
            }
        }
        private void novoJogo()
        { 
            Console.WriteLine("Aqui Estamos"); 
        }
    }
}