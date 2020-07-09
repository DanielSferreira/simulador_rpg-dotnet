using System;
using System.Collections.Generic;
using static System.Console;

namespace Componentes
{
    public class OptionsMenu
    {
        private int _escolha = 0;
        public int ShowOption()
        {
            this.getOptionsList();
            this._escolha = this.readLine();
            return this._escolha;
        }

        public int getOption()
        {
            return this._escolha;
        }

        private void getOptionsList()
        {
            
            WriteLine("");
            WriteLine("Olá, bem vindo ao simulador");
            WriteLine("**Escolha uma das opções**");
            WriteLine("1 - Novo Jogo | 2 - Carregar Jogo | 3 - Opções | 4 - Configurações do Jogador | 5 - Sair da Torre");
            
        }

        private int readLine()
        {
            
            try
            {
                
                Write("Opção: ");
                this._escolha = System.Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                
            WriteLine("Não pode letra filhão, tente novamente: ");
                return this.readLine();
            }

            if(this._escolha > 0 && this._escolha < 6)
                return this._escolha;
            else
            {
                WriteLine("número invalido, tente outro: ");
                return this.readLine();
            }
        }
    }
}