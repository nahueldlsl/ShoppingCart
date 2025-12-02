using System.Collections.Generic;

namespace Ucu.Poo.eCommerce
{
    public interface IDiscount
    {
        double CalculateTotal(IReadOnlyList<ShoppingCart.CartItem> items);
    }
}