using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursavaya2Kurs.Model;

namespace Kursavaya2Kurs.Tests
{
    [TestClass]
    public class CashPaymentStrategyTests
    {
        [TestMethod]
        public void Pay_WithSufficientCash_ShouldSucceed()
        {
            // Arrange
            var customer = new Customer { Cash = 100, BonusPoints = 0 };
            var paymentStrategy = new CashPaymentStrategy();
            decimal totalAmount = 50;

            // Act
            bool result = paymentStrategy.Pay(customer, totalAmount);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(50, customer.Cash);
            Assert.AreEqual(5, customer.BonusPoints); // 10% от 50
        }

        [TestMethod]
        public void Pay_WithInsufficientCash_ShouldFail()
        {
            // Arrange
            var customer = new Customer { Cash = 30, BonusPoints = 0 };
            var paymentStrategy = new CashPaymentStrategy();
            decimal totalAmount = 50;

            // Act
            bool result = paymentStrategy.Pay(customer, totalAmount);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(30, customer.Cash);
            Assert.AreEqual(0, customer.BonusPoints);
        }
    }
}
