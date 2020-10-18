using System;
using System.Collections.Generic;
using System.Linq;

namespace oop_hw_shoppingCart
{
    public static class PriceCalculator
    {
        public static decimal CalculateCartPrice(ShoppingCart cart)
        {
            decimal physicalBooksPriceTotal = 0;
            decimal digitalBooksPriceTotal = 0;
            decimal total = 0;
            var items = cart.GetItems();
            var authorsForDigitalSale = FindSameAuthor(items);
            foreach (var item in items)
            {
                var uniqueBook = item.book;
                decimal price = uniqueBook.price * item.saleAmount * item.count;
                if (uniqueBook.bType == BookType.Physical)
                    physicalBooksPriceTotal += price;
                else
                {
                    bool freeByAuthor = false;//Есть акция: при покупке двух бумажных книг одного автора одна электронная книга того же автора в подарок
                    foreach (var author in authorsForDigitalSale)
                    {
                        if (author == uniqueBook.GetAuthors()[0])
                            freeByAuthor = true;
                    }
                    if (!freeByAuthor)
                        digitalBooksPriceTotal += price;
                }
            }
            if(cart.GetPromo() != null)
            {
                physicalBooksPriceTotal = cart.GetPromo().PriceEdit(physicalBooksPriceTotal);
                digitalBooksPriceTotal = cart.GetPromo().PriceEdit(digitalBooksPriceTotal);
            }
            if (cart.GetPromo().GetType() == typeof(PromoDelivery) && physicalBooksPriceTotal < 1000)
            {
                total += 200;
            }

            total += digitalBooksPriceTotal + physicalBooksPriceTotal;
            return total;
        }
        private static List<string> FindSameAuthor(List<CartItem> books)
        {
            List<string> AuthorsForDigitalSale = new List<string>();
            for (int i = 0, l = books.Count - 1; i < l; i++)
            {
                string curAuthor = books[i].book.GetAuthors()[0];
                for(int j = i+1; j < l+1; j++)
                {
                    if (books[i].book.GetAuthors()[0] == curAuthor)
                    {
                        AuthorsForDigitalSale.Add(curAuthor);
                    }
                }
            }
            return AuthorsForDigitalSale;
        }
    }
}
