using System;

/*
    Separei pelo aumento de linhas, e preferi separar a interface de iteração da calcula
*/

namespace Mecanicas.game_play
{
    public class MenuCombat
    {
        public int ShowOptions()
        {
            int res;

            Console.WriteLine("1 - Lutar");
            Console.WriteLine("2 - Defender");
            Console.WriteLine("3 - Usar Item");
            Console.WriteLine("4 - Meter o pé");

            try
            {
                res = System.Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {

                Console.WriteLine("Não pode letra filhão, tente novamente: ");
                return this.ShowOptions();
            }

            if (res > 0 && res <= 4)
                return res;
            else
            {
                Console.WriteLine("número invalido, tente outro: ");
                return this.ShowOptions();
            }
        }

        public string ExecuteActions(int opt)
        {
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Você deu uma Porrada nele");
                    return "ataque";
                case 2:
                    Console.WriteLine("Você Defendeu. (covarde)");
                    return "false";
                case 3:
                    Console.WriteLine("Você vai usar qual item?");
                    return "false";
                case 4:
                    Console.WriteLine("Arreeeegoooouuuuu");
                    return "true";
                default:
                    Console.WriteLine("Acontece nada, escolheu uma opção invalida, seu bocó");
                    return "true";
            }
        }

    }
}