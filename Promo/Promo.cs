namespace oop_hw_shoppingCart
{
    abstract public class Promo
    {
        protected string code;

        public static Promo EvalPromoCode(string code)
        {
            //magic function that parses promocodes and return correct promo object
            //maybe idk...
            //also can find book corresponding to this promocode
            //but i feel that needs a database
            //so let's imagine that it did the thing :)
            return new PromoPercents(code, (decimal)0.2);
        }

        public virtual decimal PriceEdit(decimal price)
        {
            return price;
        }
    }
}
