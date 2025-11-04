using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegressionLab;
using System;

namespace RegressionLab.Tests;

[TestClass]
    [TestMethod]
    public void CalculateFinal_HandlesMidpointCorrectly()
    {
        decimal result = PriceCalculator.CalculateFinal(10m, 0.21m, 5m);
        Assert.AreEqual(11.50m, result);
    }
}
