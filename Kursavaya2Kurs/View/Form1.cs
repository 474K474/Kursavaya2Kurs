using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Kursavaya2Kurs.Model;

namespace Kursavaya2Kurs
{
    public partial class MainForm : Form
    {
        private Customer customer;
        private Store store;
        private List<Product> products;

        public MainForm()
        {
            InitializeComponent();
            customer = new Customer(); // Начальные значения будут устанавливаться из текстовых полей
            store = new Store();
            products = new List<Product>
            {
                new Product { Name = "Apple", Price = 3, IsWeighable = true },
                new Product { Name = "Bread", Price = 2, IsWeighable = false },
                // Добавьте больше продуктов, если необходимо
            };
            ProductList.DataSource = products;
            ProductList.DisplayMember = "Name";
            UpdateCartDisplay();
            UpdatePaymentInfo(); // Обновляем отображение начальных значений денег и бонусов
        }

        private void UpdateCartDisplay()
        {
            CartList.Items.Clear();
            foreach (var item in customer.Cart)
            {
                CartList.Items.Add($"{item.Product.Name} - {item.QuantityOrWeight} - {item.GetTotalPrice():C}");
            }
            totalLabel.Text = $"Total: {customer.GetTotalCartPrice():C}";
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = (Product)ProductList.SelectedItem;
            if (selectedProduct != null)
            {
                ProductInfoBox.Text = $"Name: {selectedProduct.Name}\nPrice: {selectedProduct.Price:C}";
                weighttxt.Enabled = selectedProduct.IsWeighable;
                quantitytxt.Enabled = !selectedProduct.IsWeighable;
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            var selectedProduct = (Product)ProductList.SelectedItem;
            if (selectedProduct == null) return;

            decimal quantityOrWeight = 0;

            if (selectedProduct.IsWeighable)
            {
                if (!decimal.TryParse(weighttxt.Text, out quantityOrWeight))
                {
                    MessageBox.Show("Invalid weight value.");
                    return;
                }
            }
            else
            {
                if (!decimal.TryParse(quantitytxt.Text, out quantityOrWeight))
                {
                    MessageBox.Show("Invalid quantity value.");
                    return;
                }
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

        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (CartList.SelectedItem != null)
            {
                var selectedItem = CartList.SelectedItem.ToString();
                var itemToRemove = customer.Cart.FirstOrDefault(item => $"{item.Product.Name} - {item.QuantityOrWeight} - {item.GetTotalPrice():C}" == selectedItem);
                if (itemToRemove != null)
                {
                    customer.RemoveFromCart(itemToRemove);
                }
                UpdateCartDisplay();
            }
        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            UpdateCustomerInfo(); // Обновление значений клиента перед оплатой

            decimal totalAmount = customer.GetTotalCartPrice();
            IPaymentStrategy paymentStrategy;

            if (Moneyrb.Checked)
            {
                paymentStrategy = new CashPaymentStrategy();
            }
            else if (Bonusrb.Checked)
            {
                paymentStrategy = new BonusPaymentStrategy();
            }
            else if (MonBonrb.Checked)
            {
                paymentStrategy = new MixedPaymentStrategy();
            }
            else
            {
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

        private void UpdateCustomerInfo()
        {
            // Обновляем значения денег и бонусов из текстовых полей
            if (decimal.TryParse(moneyRichTextBox.Text, out decimal cash))
            {
                customer.Cash = cash;
            }
            else
            {
                MessageBox.Show("Invalid cash value.");
            }

            if (decimal.TryParse(bonusRichTextBox.Text, out decimal bonusPoints))
            {
                customer.BonusPoints = bonusPoints;
            }
            else
            {
                MessageBox.Show("Invalid bonus points value.");
            }
        }

        private void UpdatePaymentInfo()
        {
            moneyRichTextBox.Text = customer.Cash.ToString("F2");
            bonusRichTextBox.Text = customer.BonusPoints.ToString("F2");
        }
    }

}
