using System.Collections.Generic;

namespace Ucu.Poo.eCommerce
{
    public class NoDiscount : IDiscount
    {
        public double CalculateTotal(IReadOnlyList<ShoppingCart.CartItem> items)
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.GetItemTotal();
            }

            return total;
        }
    }
}