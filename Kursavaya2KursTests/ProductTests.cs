using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursavaya2Kurs.Model;

namespace Kursavaya2Kurs.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void GetTotalPrice_ShouldReturnCorrectValue()
        {
            // Arrange
            var product = new Product { Name = "Apple", Price = 10, IsWeighable = true };

            // Act
            var totalPrice = product.GetTotalPrice(2);

            // Assert
            Assert.AreEqual(20, totalPrice);
        }
    }
}
