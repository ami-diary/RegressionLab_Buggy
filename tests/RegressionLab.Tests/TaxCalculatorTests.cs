using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegressionLab;
using System;

namespace RegressionLab.Tests;

[TestClass]
public class TaxCalculatorTests
{
    [TestMethod]
    public void ComputeAnnualTax_ZeroAndNegativeIncome()
    {
        Assert.AreEqual(0m, TaxCalculator.ComputeAnnualTax(0m));
        Assert.AreEqual(0m, TaxCalculator.ComputeAnnualTax(-100m));
    }

    [TestMethod]
    public void ComputeAnnualTax_BracketsWork()
    {
        Assert.AreEqual(6000m, TaxCalculator.ComputeAnnualTax(60_000m));
    }

