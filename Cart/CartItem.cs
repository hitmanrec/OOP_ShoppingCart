using System;
using System.Collections.Generic;
using System.Linq;

namespace oop_hw_shoppingCart
{
    public class CartItem
    {
        public Book book { get; }
        public int count { get; }
        public decimal saleAmount { get; }
        public CartItem (Book _book, int _count, decimal _saleAmount = 0)
        {
            if (book == null || _count < 1 || _count > 99 || (book.bType == BookType.Digital && count != 1))
                throw new ArgumentException("Invalid book or book count!");
            book = _book;
            count = _count;
            saleAmount = _saleAmount;
        }
    }
}
