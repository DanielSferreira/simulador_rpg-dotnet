using System;
using Entidades.Classes;
using Mecanicas;
namespace Componentes
{
    public class Menu
    {
        public Menu()
        {
            var opt = new OptionsMenu();
            bool isContinue = true;

            while (isContinue)
            {
                isContinue = this.option(opt.ShowOption());
            }

        }
        private bool option(int opt)
        {
            switch (opt)
            {
                case 1:
                    this.novoJogo();
                    break;
                case 2:
                    this.carregarJogo();
                    break;
                case 3:
                    this.carregarOpcoes();
                    break;
                case 4:
                    this.criarJogador();
                    break;
                case 5:
                    Console.WriteLine("Acabou");
                    return false;
            }
            return true;
        }
        private void novoJogo()
        { 
            new StartGame(); 
        }
        private void carregarJogo()
        {
            Console.WriteLine("Carregando jogo");
        }
        private void carregarOpcoes()
        {
            Console.WriteLine("Carregando Opções do joho");
        }
        private void criarJogador()
        {
            Console.WriteLine("Carregando Opções do jau");
        }
        private void ErroOpcao()
        {
            Console.WriteLine("Carregando jogo");
        }
    }
}