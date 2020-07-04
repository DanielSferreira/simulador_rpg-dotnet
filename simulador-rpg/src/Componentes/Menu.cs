using System;
using Entidades.Classes;
using Mecanicas;
namespace Componentes
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
                case 2:
                    this.carregarJogo();  
                    return;
                case 3:
                    this.carregarOpcoes();  
                    return;
                case 4:
                    this.criarJogador();  
                    return;
            }
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
        } 
        private void ErroOpcao()
        {
            Console.WriteLine("Carregando jogo");
        } 
    }  
}