using System;
namespace Mecanicas.game_play
{
    public class MenuCombat
    {
        public int ShowOptions()
        {
            int res;

            Console.WriteLine("1 - Lutar | 2 - Defender | 3 - Usar Item | 4 - Meter o pé");

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
    }
}