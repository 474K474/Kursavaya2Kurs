using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursavaya2Kurs.Model;
using System.Collections.Generic;

namespace Kursavaya2Kurs.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void AddToCart_ShouldAddItemToCart()
        {
            // Arrange
            var customer = new Customer();
            var product = new Product { Name = "Apple", Price = 10, IsWeighable = true };
            var cartItem = new CartItem { Product = product, QuantityOrWeight = 1 };

            // Act
            customer.AddToCart(cartItem);

            // Assert
            Assert.AreEqual(1, customer.Cart.Count);
            Assert.AreEqual(cartItem, customer.Cart[0]);
        }

        [TestMethod]
        public void RemoveFromCart_ShouldRemoveItemFromCart()
        {
            // Arrange
            var customer = new Customer();
            var product = new Product { Name = "Apple", Price = 10, IsWeighable = true };
            var cartItem = new CartItem { Product = product, QuantityOrWeight = 1 };
            customer.AddToCart(cartItem);

            // Act
            customer.RemoveFromCart(cartItem);

            // Assert
            Assert.AreEqual(0, customer.Cart.Count);
        }

        [TestMethod]
        public void GetTotalCartPrice_ShouldReturnCorrectTotal()
        {
            // Arrange
            var customer = new Customer();
            var product1 = new Product { Name = "Apple", Price = 10, IsWeighable = true };
            var product2 = new Product { Name = "Banana", Price = 5, IsWeighable = true };
            customer.AddToCart(new CartItem { Product = product1, QuantityOrWeight = 1 });
            customer.AddToCart(new CartItem { Product = product2, QuantityOrWeight = 2 });

            // Act
            var total = customer.GetTotalCartPrice();

            // Assert
            Assert.AreEqual(20, total);
        }
    }
}
