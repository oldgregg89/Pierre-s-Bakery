using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresBakery.Models;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_WillCreateAPastryObject_Word()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
    [TestMethod]
    [DataRow(3,5)]
    [DataRow(5,11)]
    [DataRow(14,26)]
    [DataRow(22,38)]
    public void TwoAndOneHalfPrice_WillProvideTheCostOfPastryForAnOrderOfThree_Int(int count, int expectedValue)
    {
      Pastry testPastry = new Pastry();
      int PastryDeal = testPastry.GetPastryTotalCost(count);
      Assert.AreEqual(expectedValue, PastryDeal);
    }
  }
}