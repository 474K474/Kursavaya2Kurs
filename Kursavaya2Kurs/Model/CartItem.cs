using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursavaya2Kurs.Model
{
    public class CartItem
    {
        public Product Product { get; set; }
        public decimal QuantityOrWeight { get; set; }

        public decimal GetTotalPrice()
        {
            return Product.GetTotalPrice(QuantityOrWeight);
        }
    }

}
