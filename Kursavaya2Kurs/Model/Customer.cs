using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursavaya2Kurs.Model
{
    public class Customer
    {
        public decimal Cash { get; set; }
        public decimal BonusPoints { get; set; }
        public List<CartItem> Cart { get; private set; }

        public Customer()
        {
            Cart = new List<CartItem>();
        }

        public void AddToCart(CartItem item)
        {
            Cart.Add(item);
        }

        public void RemoveFromCart(CartItem item)
        {
            Cart.Remove(item);
        }

        public decimal GetTotalCartPrice()
        {
            return Cart.Sum(item => item.GetTotalPrice());
        }

        public void ClearCart()
        {
            Cart.Clear();
        }
    }

}
