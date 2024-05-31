using Kursavaya2Kurs.Model;
using Kursavaya2Kurs.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursavaya2Kurs.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView view;
        private readonly Customer customer;
        private readonly Store store;
        private readonly List<Product> products;

        public MainPresenter(IMainView view)
        {
            this.view = view;
            customer = new Customer();
            store = new Store();
            products = new List<Product>
            {
                new Product { Name = "Apple", Price = 3, IsWeighable = true },
                new Product { Name = "Bread", Price = 2, IsWeighable = false },
                new Product {Name = "Meat", Price = 20, IsWeighable = true},
                // Добавьте больше продуктов, если необходимо
            };

            this.view.Products = products;
            UpdateCartDisplay();
            UpdatePaymentInfo();

            this.view.AddProduct += View_AddProduct;
            this.view.RemoveProduct += View_RemoveProduct;
            this.view.Pay += View_Pay;
            this.view.UpdateCustomerInfo += View_UpdateCustomerInfo;
            this.view.SelectedProductChanged += View_SelectedProductChanged;
        }

        private void View_AddProduct(object sender, EventArgs e)
        {
            var selectedProduct = view.SelectedProduct;
            if (selectedProduct == null) return;

            if (!decimal.TryParse(view.QuantityOrWeight, out decimal quantityOrWeight))
            {
                MessageBox.Show("Invalid quantity or weight value.");
                return;
            }

            var builder = new CartBuilder();
            builder.AddProduct(selectedProduct, quantityOrWeight);
            var items = builder.Build();

            foreach (var item in items)
            {
                customer.AddToCart(item);
            }

            UpdateCartDisplay();
        }

        private void View_RemoveProduct(object sender, EventArgs e)
        {
            var selectedItem = view.SelectedCartItem;
            if (selectedItem != null)
            {
                var itemToRemove = customer.Cart.FirstOrDefault(item => $"{item.Product.Name} - {item.QuantityOrWeight} - {item.GetTotalPrice():C}" == selectedItem);
                if (itemToRemove != null)
                {
                    customer.RemoveFromCart(itemToRemove);
                }
                UpdateCartDisplay();
            }
        }

        private void View_Pay(object sender, EventArgs e)
        {
            UpdateCustomerInfo();

            decimal totalAmount = customer.GetTotalCartPrice();
            IPaymentStrategy paymentStrategy;

            switch (view.SelectedPaymentMethod)
            {
                case PaymentMethod.Cash:
                    paymentStrategy = new CashPaymentStrategy();
                    break;
                case PaymentMethod.Bonus:
                    paymentStrategy = new BonusPaymentStrategy();
                    break;
                case PaymentMethod.Mixed:
                    paymentStrategy = new MixedPaymentStrategy();
                    break;
                default:
                    MessageBox.Show("Please select a payment method.");
                    return;
            }

            if (paymentStrategy.Pay(customer, totalAmount))
            {
                MessageBox.Show("Purchase successful!");
                customer.Cart.Clear();
                UpdateCartDisplay();
                UpdatePaymentInfo();
            }
            else
            {
                MessageBox.Show("Insufficient funds or invalid payment.");
            }
        }

        private void View_UpdateCustomerInfo(object sender, EventArgs e)
        {
            if (decimal.TryParse(view.Cash, out decimal cash))
            {
                customer.Cash = cash;
            }
            else
            {
                MessageBox.Show("Invalid cash value.");
            }

            if (decimal.TryParse(view.BonusPoints, out decimal bonusPoints))
            {
                customer.BonusPoints = bonusPoints;
            }
            else
            {
                MessageBox.Show("Invalid bonus points value.");
            }
        }

        private void View_SelectedProductChanged(object sender, EventArgs e)
        {
            var selectedProduct = view.SelectedProduct;
            if (selectedProduct != null)
            {
                view.SelectedProductInfo = $"Name: {selectedProduct.Name}\nPrice: {selectedProduct.Price:C}";
                view.IsWeightEnabled = selectedProduct.IsWeighable;
                view.IsQuantityEnabled = !selectedProduct.IsWeighable;
            }
        }

        private void UpdateCartDisplay()
        {
            view.CartItems = customer.Cart.ToList();
            view.TotalPrice = customer.GetTotalCartPrice();
        }

        private void UpdatePaymentInfo()
        {
            view.Cash = customer.Cash.ToString("F2");
            view.BonusPoints = customer.BonusPoints.ToString("F2");
        }

        private void UpdateCustomerInfo()
        {
            if (decimal.TryParse(view.Cash, out decimal cash))
            {
                customer.Cash = cash;
            }
            else
            {
                MessageBox.Show("Invalid cash value.");
            }

            if (decimal.TryParse(view.BonusPoints, out decimal bonusPoints))
            {
                customer.BonusPoints = bonusPoints;
            }
            else
            {
                MessageBox.Show("Invalid bonus points value.");
            }
        }
    }

}
