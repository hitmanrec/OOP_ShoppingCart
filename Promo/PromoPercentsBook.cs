namespace oop_hw_shoppingCart
{
    public class PromoPercentsBook : PromoPercents
    {
        public Book book { get; }
        public PromoPercentsBook(string _code, decimal saleAmount, Book _book) : base (_code, saleAmount)
        {
            book = _book;
        }
    }
}
