using System.Collections.Generic;

namespace Ucu.Poo.eCommerce
{
    public class CategoryDiscount : IDiscount
    {
        private string category;
        private double percentage;

        public CategoryDiscount(string category, double percentage)
        {
            this.category = category;
            this.percentage = percentage;
        }

        public double CalculateTotal(IReadOnlyList<ShoppingCart.CartItem> items)
        {
            double total = 0;
            foreach (var item in items)
            {
                if (item.Product.Category == this.category)
                {
                    total += item.GetItemTotal() * (1 - percentage);
                }
                else
                {
                    total += item.GetItemTotal();
                }
            }

            return total;
        }
    }
}