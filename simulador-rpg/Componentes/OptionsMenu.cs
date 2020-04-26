using System;
using static System.Console;

namespace Componentes
{
    public class OptionsMenu
    {
        private int _opt = -1;
        public OptionsMenu()
        {
            WriteLine("Olá, bem vindo ao simulador");
            WriteLine("**Escolha uma das opções**");
            WriteLine("1 - Novo Jogo");
            WriteLine("2 - Carregar Jogo");
            WriteLine("3 - Opções");

            while (this._opt < 1)
            {
                this.readLine();
            }

        }
        public int getOption(){
            return this._opt;
        }
        private int readLine()
        {
            
            try
            {
                var lerEscolha = Console.ReadLine();
                this._opt = System.Convert.ToInt32(lerEscolha);
            }
            catch (System.Exception)
            {
                return -1;
            }

            if(this._opt < 0 || this._opt >3)
            {
                return this._opt;
            }
            else
            {
                return -1;
            }
        }
    }
}