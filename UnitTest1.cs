using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Klub; // Ссылка на проект Klub

namespace TestKlub
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_NormalCondition_DiscountApplied()
        {
            // Arrange
            MainWindow mainWindow = new MainWindow();
            decimal originalPrice = 100m;
            decimal? discount = 20m; // 20%
            decimal expectedPrice = 80m; // 100 - 20%

            // Act
            var result = mainWindow.CalculateDiscountedPrice(originalPrice, discount);

            // Assert
            Assert.AreEqual(expectedPrice, result, "The discount calculation failed for normal conditions.");
        }

        [TestMethod]
        public void Test_ExtremeCondition_NoDiscount()
        {
            // Arrange
            MainWindow mainWindow = new MainWindow();
            decimal originalPrice = 100m;
            decimal? discount = 0m; // No discount
            decimal expectedPrice = 100m;

            // Act
            var result = mainWindow.CalculateDiscountedPrice(originalPrice, discount);

            // Assert
            Assert.AreEqual(expectedPrice, result, "The discount calculation failed for an edge case of no discount.");
        }

        [TestMethod]
        public void Test_ExceptionalCondition_NullDiscount()
        {
            // Arrange
            MainWindow mainWindow = new MainWindow();
            decimal originalPrice = 100m;
            decimal? discount = null; // Null discount
            decimal expectedPrice = 100m;

            // Act
            var result = mainWindow.CalculateDiscountedPrice(originalPrice, discount);

            // Assert
            Assert.AreEqual(expectedPrice, result, "The discount calculation failed for a null discount.");
        }
    }
}
