using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegressionLab;
using System;

namespace RegressionLab.Tests;

[TestClass]
public class LoyaltyPointsTests
{
    [TestMethod]
    public void PointsExpireAfterThreeMonths_FifoSpend()
    {
        var lp = new LoyaltyPoints();
        lp.AddPoints(new DateTime(2025, 1, 1), 100);
        lp.AddPoints(new DateTime(2025, 2, 1), 50);
        lp.AddPoints(new DateTime(2025, 3, 1), 25);
        int spent = lp.Spend(new DateTime(2025, 4, 1), 120);
        Assert.AreEqual(75, spent);
        Assert.AreEqual(0, lp.Balance(new DateTime(2025, 4, 1)));
    }

    [TestMethod]
    public void Spend_PartialBurnAndBalance()
    {
        var lp = new LoyaltyPoints();
        lp.AddPoints(new DateTime(2025, 5, 1), 60);
        lp.AddPoints(new DateTime(2025, 6, 1), 40);
        int spent = lp.Spend(new DateTime(2025, 6, 1), 50);
        Assert.AreEqual(50, spent);
        Assert.AreEqual(50, lp.Balance(new DateTime(2025, 6, 1)));
    }
}
