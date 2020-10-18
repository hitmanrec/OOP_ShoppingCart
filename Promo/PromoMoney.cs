using System;

namespace oop_hw_shoppingCart
{
    public class PromoMoney : Promo
    {
        protected decimal amount;
        public decimal GetAmount() => amount;

        public override decimal PriceEdit(decimal price)
        {
            if (price <= amount)
                return 0;
            else return price - amount;
        }

        public PromoMoney(string _code, decimal saleAmount)
        {
            if (saleAmount < 5)
                throw new ArgumentException("Invalid sale amount!");
            code = _code;
            amount = saleAmount;
        }
    }
}
