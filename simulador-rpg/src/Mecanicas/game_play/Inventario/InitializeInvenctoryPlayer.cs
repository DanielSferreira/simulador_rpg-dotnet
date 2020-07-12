using System.Collections.Generic;
using Mecanicas.game_play.Inventario.itens;

namespace Mecanicas.game_play.Inventario
{
    public class InitializeInvenctoryPlayer
    {
        
        public InitializeInvenctoryPlayer()
        {
            this.InitInvectoryDefaultPlayer(new Potion_p());
            this.InitInvectoryDefaultPlayer(new Potion_m());
            this.InitInvectoryDefaultPlayer(new Potion_g());
        }

        private int _current = 1;
        public List<InvectoryItem> _items = new List<InvectoryItem>();
        
        private void InitInvectoryDefaultPlayer(Item i)
        {
            this._items.Add(
                new InvectoryItem().setNewItem(i,1, this._current)
            );
            
            this._current++;
        }

        public void shopItem()
        {
            new ShopItems();
        }
        public int showInvectory()
        {
            int n = 0;
            System.Console.WriteLine($"Digite o Id do item para usa-lo");
            foreach (var i in this._items)
                System.Console.WriteLine($"Id: {i._posicao} \t Item: {i._item.name} \t Quantidade: {i._quantidade}");

            try 
            {
                n =  System.Convert.ToInt32(System.Console.ReadLine());
                if (n < 0 || n > this._items.Count-1)
                    this.showInvectory();
            } 
            catch(System.Exception)
            {
                this.showInvectory();
            }
            return n;
        }
    }
}