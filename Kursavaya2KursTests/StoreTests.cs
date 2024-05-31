using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursavaya2Kurs.Model;

namespace Kursavaya2Kurs.Tests
{
    [TestClass]
    public class StoreTests
    {
        [TestMethod]
        public void CheckOut_ShouldReturnTrue_WhenPaymentIsSufficient()
        {
            // Arrange
            var store = new Store();
            var customer = new Customer { Cash = 50, BonusPoints = 50 };
            var product = new Product { Name = "Apple", Price = 10, IsWeighable = true };
            customer.AddToCart(new CartItem { Product = product, QuantityOrWeight = 1 });

            // Act
            var result = store.CheckOut(customer, 10, 40);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckOut_ShouldReturnFalse_WhenPaymentIsInsufficient()
        {
            // Arrange
            var store = new Store();
            var customer = new Customer { Cash = 5, BonusPoints = 5 };
            var product = new Product { Name = "Apple", Price = 10, IsWeighable = true };
            customer.AddToCart(new CartItem { Product = product, QuantityOrWeight = 1 });

            // Act
            var result = store.CheckOut(customer, 5, 4);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
