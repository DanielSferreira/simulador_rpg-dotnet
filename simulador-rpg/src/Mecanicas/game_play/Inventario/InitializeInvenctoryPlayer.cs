using System.Collections.Generic;
using Entidades;
using Mecanicas.game_play.Inventario.itens;

namespace Mecanicas.game_play.Inventario
{
    public class InitializeInvenctoryPlayer
    {
        
        public InitializeInvenctoryPlayer()
        {
            this.AddItemToList(new Potion_p());
        }

        private int _current = 1;
        public List<InvectoryItem> _items = new List<InvectoryItem>();
        public Dictionary<int, InvectoryItem> _items2 = new Dictionary<int, InvectoryItem>();
        
        private void AddItemToList(Item i)
        {
            /*Lista*/
            // foreach (var item in this._items)
            // {
            //     if(i.name == item._item.name)
            //     {
            //         item._quantidade++;
            //         return;
            //     }
            // }
            /*Dicionario*/
            foreach (var item in this._items2)
            {
                if(i.name == item.Value._item.name)
                {
                    item.Value._quantidade++;
                    return;
                }
            }
            /*Lista*/ //this._items.Add( new InvectoryItem().AddItemThatDoesNotExistYet(i,1, this._current++) );
            /*Dicionario*/ this._items2.Add( this._current++, new InvectoryItem().AddItemThatDoesNotExistYet(i,1, this._current) );
            
            //this._current++;
        }

        public void shopItem(Player p)
        {
            var shop = new ShopItems();
            this.AddItemToList(shop._shop());
        }
        public int showInvectory()
        {
            // int n = 0;
            // System.Console.WriteLine($"Digite o Id do item para usa-lo");
            // foreach (var i in this._items)
            //     System.Console.WriteLine($"Id: {i._posicao} \t Item: {i._item.name} \t Quantidade: {i._quantidade}");

            // try 
            // {
            //     n =  System.Convert.ToInt32(System.Console.ReadLine());
            //     if (n < 0 || n > this._items.Count-1)
            //         this.showInvectory();
            // } 
            // catch(System.Exception)
            // {
            //     this.showInvectory();
            // }
            // return n;

            int n = 0;
            System.Console.WriteLine($"Digite o Id do item para usa-lo");
            foreach (var i in this._items2)
                System.Console.WriteLine($"Id: {i.Key} \t Item: {i.Value._item.name} \t Quantidade: {i.Value._quantidade}");

            try 
            {
                n =  System.Convert.ToInt32(System.Console.ReadLine());
                if (n < 0 || n > this._items2.Count)
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