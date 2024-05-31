using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursavaya2Kurs.Model
{
    public class CartBuilder
    {
        private List<CartItem> _items = new List<CartItem>();

        public CartBuilder AddProduct(Product product, decimal quantityOrWeight)
        {
            _items.Add(new CartItem { Product = product, QuantityOrWeight = quantityOrWeight });
            return this;
        }

        public List<CartItem> Build()
        {
            return _items;
        }
    }

}
