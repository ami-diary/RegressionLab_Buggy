using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegressionLab;
using System;

namespace RegressionLab.Tests;

[TestClass]
public class StringNormalizerTests
{
    [TestMethod]
    public void NormalizeProductCode_TrimsAndUppercases()
    {
        Assert.AreEqual("ABC-123", StringNormalizer.NormalizeProductCode("  abc 123  "));
    }

    [TestMethod]
    public void NormalizeProductCode_RemovesSymbolsAndCollapses()
    {
        Assert.AreEqual("A12-B34", StringNormalizer.NormalizeProductCode("A12__  **b34"));
    }

    [TestMethod]
    public void NormalizeProductCode_EmptyForNullOrWhitespace()
    {
        Assert.AreEqual(string.Empty, StringNormalizer.NormalizeProductCode(null));
        Assert.AreEqual(string.Empty, StringNormalizer.NormalizeProductCode("   "));
    }
}
