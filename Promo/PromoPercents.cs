using System;

namespace oop_hw_shoppingCart
{
    public class PromoPercents : Promo
    {
        protected decimal amount;
        public decimal GetAmount() => amount;
        public PromoPercents(string _code, decimal saleAmount)
        {
            if (saleAmount > 1 || saleAmount < (decimal)0.05)
                throw new ArgumentException("Invalid sale amount!");
            code = _code;
            amount = saleAmount;
        }

        public override decimal PriceEdit(decimal price)
        {
            return price * amount;
        }
    }
}
