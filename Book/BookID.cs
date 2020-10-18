using System;

namespace oop_hw_shoppingCart
{
    public class BookID
    {
        //we imagine that this class links our book to database
        public string id { get; }
        public BookID(string _id)
        {
            if (IsValid(_id))
                id = _id;
            else throw new ArgumentException("Invalid book id!");
        }
        public BookID()
        {
            id = GenerateID();
        }

        private static string GenerateID()
        {
            var rand = new Random();
            string id = "";
            for(int i = 0; i < 10; i++)
            {
                id += (char)rand.Next('A', 'Z');
            }
            return id;
        }
        private static bool IsValid(string id)
        {
            //some complicated validation algorithm
            //if...
            //if...
            //.....
            return true;
        }
    }
}
