using System;
using System.Collections.Generic;
using static System.Console;

namespace Mecanicas.game_play
{
    public class OptionsMenu
    {
        private int _escolha = 0;
        private List<string> options = new List<string>();

        public OptionsMenu()
        {
            WriteLine("Párabens, estamos na torre, Agora vamos subir");
            this.setOptionsList();
        }
        public void ShowOptions()
        {
            this.getOptionsList();
            this._escolha = this.readLine();
        }

        public int getOption()
        {
            return this._escolha;
        }

        private void setOptionsList() =>
            this.options.Add("1 - Prosseguir | 2 - Status | 3 - Itens | 4 - Chutar o balde");

        private void getOptionsList()
        {
            WriteLine("");
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

            if(this._escolha > 0 && this._escolha <= 4)
                return this._escolha;
            else
            {
                WriteLine("número invalido, tente outro: ");
                return this.readLine();
            }
        }
    }
}