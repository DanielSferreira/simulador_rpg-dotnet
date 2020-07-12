using Mecanicas.game_play.Inventario.itens;
using Entidades;

namespace Mecanicas.game_play.Inventario
{
    public class InvectoryItem
    {
        public  Item _item { get; set; }
        public int _quantidade { get; set; }
        public int _posicao { get; set; }

        public InvectoryItem AddItemThatDoesNotExistYet( Item item, int quantidade, int posicao )
        {
            this._item = item;
            this._quantidade = quantidade;
            this._posicao = posicao;

            return this;
        }

        public InvectoryItem AddItemThatAlreadyExists( Item item )
        {
            return this;
        }
        public void useItem(Player p)
        {
            if (this._quantidade > 0)
            {
                this._item.action(p);
                System.Console.WriteLine($"O item {this._item.name} foi usado invetário!");
                this._quantidade--;
            } else {
                System.Console.WriteLine("não possui esse item no invetário!");
            }
        }
    }
}