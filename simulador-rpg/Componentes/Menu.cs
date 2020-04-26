using System;
namespace Componentes
{
    public class Menu
    {
        private OptionsMenu _option;
        private int _escolha;
        public Menu()
        {
            this._option = new OptionsMenu();
            this.option(this._option.getOption());
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
            }
        }
        private void novoJogo()
        {
            Console.WriteLine("Novo jogo criado");
        } 
        private void carregarJogo()
        {
            Console.WriteLine("Carregando jogo");
        } 
        private void carregarOpcoes()
        {
            Console.WriteLine("Carregando Opções do joho");
        } 
        private void ErroOpcao()
        {
            Console.WriteLine("Carregando jogo");
        } 
    }  
}