using System;
using System.Collections.Generic;
using System.Linq;

namespace oop_hw_shoppingCart
{
    public class ShoppingCart
    {
        private List<CartItem> items;
        public List<CartItem> GetItems() => items.ToList();

        private Promo promo;
        public Promo GetPromo() => promo;
        public void SetPromo(Promo p)
        {
            promo = p;
        }
        public ShoppingCart()
        {
            items = new List<CartItem>();
        }
        public void Add(Book book, decimal saleAmount = 0, int count = 1)
        {
            items.Add(new CartItem(book, count, saleAmount));
        }
        public void AddRange(ShoppingCart cart)
        {
            items.AddRange(cart.GetItems());
        }
        

    }
}
