using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Kursavaya2Kurs.Model;
using Kursavaya2Kurs.Presenter;
using Kursavaya2Kurs.View;
using System.Collections.Generic;
using System;

namespace Kursavaya2Kurs.Tests
{
    [TestClass]
    public class MainPresenterTests
    {
        private Mock<IMainView> viewMock;
        private MainPresenter presenter;

        [TestInitialize]
        public void Setup()
        {
            viewMock = new Mock<IMainView>();
            presenter = new MainPresenter(viewMock.Object);
        }

        [TestMethod]
        public void AddProduct_ShouldAddProductToCart()
        {
            // Arrange
            var product = new Product { Name = "Apple", Price = 3, IsWeighable = true };
            viewMock.Setup(v => v.SelectedProduct).Returns(product);
            viewMock.Setup(v => v.QuantityOrWeight).Returns("1");

            // Act
            viewMock.Raise(v => v.AddProduct += null, EventArgs.Empty);

            // Assert
            viewMock.VerifySet(v => v.CartItems = It.IsAny<List<CartItem>>());
        }

        [TestMethod]
        public void RemoveProduct_ShouldRemoveProductFromCart()
        {
            // Arrange
            var product = new Product { Name = "Apple", Price = 3, IsWeighable = true };
            var cartItem = new CartItem { Product = product, QuantityOrWeight = 1 };
            viewMock.Setup(v => v.SelectedCartItem).Returns($"{product.Name} - 1 - {cartItem.GetTotalPrice():C}");

            // Act
            viewMock.Raise(v => v.RemoveProduct += null, EventArgs.Empty);

            // Assert
            viewMock.VerifySet(v => v.CartItems = It.IsAny<List<CartItem>>());
        }

        [TestMethod]
        public void Pay_ShouldProcessPayment()
        {
            // Arrange
            viewMock.Setup(v => v.SelectedPaymentMethod).Returns(PaymentMethod.Cash);
            viewMock.Setup(v => v.Cash).Returns("100");

            // Act
            viewMock.Raise(v => v.Pay += null, EventArgs.Empty);

            // Assert
            viewMock.VerifySet(v => v.TotalPrice = 0);
            viewMock.VerifySet(v => v.CartItems = new List<CartItem>());
        }
    }
}
