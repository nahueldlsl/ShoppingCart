using System.Collections.Generic;

namespace Ucu.Poo.eCommerce
{
    public class Dosporuno : IDiscount

    {
        public double CalculateTotal(IReadOnlyList<ShoppingCart.CartItem> items)
        {
            double total = 0;
            foreach (var item in items)
            {
                int itemsapagar = (item.Quantity / 2);
                total += itemsapagar*item.Product.Price;
                ;
            }

            return total;
        }
    }
}