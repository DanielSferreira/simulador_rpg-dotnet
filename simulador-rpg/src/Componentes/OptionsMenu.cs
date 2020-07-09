using System;
using System.Collections.Generic;
using static System.Console;

namespace Componentes
{
    public class OptionsMenu
    {
        private int _escolha = 0;
        private List<string> options = new List<string>();

        public OptionsMenu()
        {
            this.setOptionsList();
            this.getOptionsList();
            this._escolha = this.readLine();
        }

        public int getOption()
        {
            return this._escolha;
        }

        private void setOptionsList()
        {
            
            this.options.Add("1 - Novo Jogo | 2 - Carregar Jogo | 3 - Opções | 4 - Configurações do Jogador");
        }

        private void getOptionsList()
        {
            
            WriteLine("");
            WriteLine("Olá, bem vindo ao simulador");
            WriteLine("**Escolha uma das opções**");
            
            foreach (var item in this.options)
                WriteLine(item);
            
            WriteLine("");
        }

        private int readLine()
        {
            
            try
            {
                this._escolha = System.Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                
            WriteLine("Não pode letra filhão, tente novamente: ");
                return this.readLine();
            }

            if(this._escolha > 0 && this._escolha < this.options.Count+1)
                return this._escolha;
            else
            {
                WriteLine("número invalido, tente outro: ");
                return this.readLine();
            }
        }
    }
}