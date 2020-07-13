using System.Collections.Generic;
using Mecanicas.game_play.Inventario.itens;

namespace Mecanicas.game_play.Inventario
{
    public class ShopItems
    {
        public Dictionary<int, Item> _shopItemList = new Dictionary<int, Item>();

        public ShopItems()
        {
            this._loadItemsForShop();
        }

        public void _loadItemsForShop()
        {
            this._shopItemList.Add(1, new Potion_p());
            this._shopItemList.Add(2, new Potion_m());
            this._shopItemList.Add(3, new Potion_g());
            
            System.Console.WriteLine("\t Digite o número do id do item que deseja comprar", System.Drawing.Color.Orange);
            System.Console.WriteLine("\n\nID \t Item");
            foreach (var item in this._shopItemList)
                System.Console.WriteLine($"{item.Key} \t {item.Value.name}");
        }

        public Item _shop()
        {
            System.Console.Write($"Id: ");
            int i = 0;
            
            try 
            {
                i =  System.Convert.ToInt32(System.Console.ReadLine());
                if (i < 0 || i > this._shopItemList.Count)
                    this._shop();
            } 
            catch(System.Exception)
            {
                this._shop();
            }
            return this._shopItemList[i];

        }
    }
}