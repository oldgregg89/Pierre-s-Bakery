using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresBakery.Models;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_WillCreateABreadObject_Word()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    [DataRow(3,10)]
    [DataRow(5,20)]
    [DataRow(14,50)]
    [DataRow(22,75)]
    public void TwoForOne_WillProvideTheCostOfBreadDealForAnOrderOfThree_Int(int count, int expectedValue)
    {
      Bread testBread = new Bread();
      int result = testBread.GetBreadTotalCost(count);
      Assert.AreEqual(expectedValue, result);
    }
  }
}