using System;
using System.Collections.Generic;
using System.Linq;

namespace oop_hw_shoppingCart
{
    public class Book
    {

        public BookID id { get; }
        public string title { get; }
        public int nPages { get; }
        public decimal price { get; }
        public BookType bType { get; }

        private List<string> authors;
        public List<string> GetAuthors() => authors.ToList();

        public Book(string _title, List<string> _authors, int numberOfPages, decimal _price, BookType bookType, string _id = "")
        {
            if (_title.Length == 0)
                throw new ArgumentException("Book title can't be empty!");
            if (_authors.Count == 0)
                throw new ArgumentException("Book must have at least one author!");
            if (numberOfPages <= 1)
                throw new ArgumentException("Number of pages must be a positive number!");
            if (_price <= 1)
                throw new ArgumentException("Price must be a positive number!");
            if (_id.Length > 0)
                id = new BookID(_id);
            else
                id = new BookID();
            title = _title;
            nPages = numberOfPages;
            price = _price;
            authors = _authors.ToList();
            bType = bookType;
        }
    }
}
