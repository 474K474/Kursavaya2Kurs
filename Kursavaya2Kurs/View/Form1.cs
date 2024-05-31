using Kursavaya2Kurs.Model;
using Kursavaya2Kurs.Presenter;
using Kursavaya2Kurs.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kursavaya2Kurs
{
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter presenter;

        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }

        public List<Product> Products
        {
            set
            {
                ProductList.DataSource = value;
                ProductList.DisplayMember = "Name";
            }
        }

        public List<CartItem> CartItems
        {
            set
            {
                CartList.Items.Clear();
                foreach (var item in value)
                {
                    CartList.Items.Add($"{item.Product.Name} - {item.QuantityOrWeight} - {item.GetTotalPrice():C}");
                }
            }
        }

        public string SelectedProductInfo
        {
            set => ProductInfoBox.Text = value;
        }

        public decimal TotalPrice
        {
            set => totalLabel.Text = $"Total: {value:C}";
        }

        public string Cash
        {
            get => moneyRichTextBox.Text;
            set => moneyRichTextBox.Text = value;
        }

        public string BonusPoints
        {
            get => bonusRichTextBox.Text;
            set => bonusRichTextBox.Text = value;
        }

        public bool IsWeightEnabled
        {
            set => weighttxt.Enabled = value;
        }

        public bool IsQuantityEnabled
        {
            set => quantitytxt.Enabled = value;
        }

        public Product SelectedProduct => (Product)ProductList.SelectedItem;

        public string QuantityOrWeight => SelectedProduct?.IsWeighable == true ? weighttxt.Text : quantitytxt.Text;

        public string SelectedCartItem => CartList.SelectedItem?.ToString();

        public PaymentMethod SelectedPaymentMethod
        {
            get
            {
                if (Moneyrb.Checked) return PaymentMethod.Cash;
                if (Bonusrb.Checked) return PaymentMethod.Bonus;
                if (MonBonrb.Checked) return PaymentMethod.Mixed;
                return PaymentMethod.None;
            }
        }

        public event EventHandler AddProduct;
        public event EventHandler RemoveProduct;
        public event EventHandler Pay;
        public event EventHandler UpdateCustomerInfo;
        public event EventHandler SelectedProductChanged;

        private void Addbtn_Click(object sender, EventArgs e) => AddProduct?.Invoke(sender, e);

        private void Delbtn_Click(object sender, EventArgs e) => RemoveProduct?.Invoke(sender, e);

        private void Paybtn_Click(object sender, EventArgs e) => Pay?.Invoke(sender, e);

        private void moneyRichTextBox_TextChanged(object sender, EventArgs e) => UpdateCustomerInfo?.Invoke(sender, e);

        private void bonusRichTextBox_TextChanged(object sender, EventArgs e) => UpdateCustomerInfo?.Invoke(sender, e);

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e) => SelectedProductChanged?.Invoke(sender, e);
    }

    public enum PaymentMethod
    {
        None,
        Cash,
        Bonus,
        Mixed
    }
}
