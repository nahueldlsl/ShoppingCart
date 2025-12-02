
using System.Collections.Generic;

namespace Ucu.Poo.eCommerce
{
    public class TotalPorcentageDiscount : IDiscount
    {
        private double porcentaje;

        public TotalPorcentageDiscount(double porcentaje)
        {
            this.porcentaje = porcentaje;
        }

        public double CalculateTotal(IReadOnlyList<ShoppingCart.CartItem> items)
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.GetItemTotal();
            }
            return total *(1-porcentaje);
        }
    }
}