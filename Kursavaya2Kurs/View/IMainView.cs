using Kursavaya2Kurs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursavaya2Kurs.View
{
    public interface IMainView
    {
        List<Product> Products { set; }
        List<CartItem> CartItems { set; }
        string SelectedProductInfo { set; }
        decimal TotalPrice { set; }
        string Cash { get; set; }
        string BonusPoints { get; set; }
        bool IsWeightEnabled { set; }
        bool IsQuantityEnabled { set; }
        Product SelectedProduct { get; }
        string QuantityOrWeight { get; }
        string SelectedCartItem { get; }
        PaymentMethod SelectedPaymentMethod { get; }

        event EventHandler AddProduct;
        event EventHandler RemoveProduct;
        event EventHandler Pay;
        event EventHandler UpdateCustomerInfo;
        event EventHandler SelectedProductChanged;
    }
}
