using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class Pastry
  {
    [TestMethod]
    public void PastryConstructor_WillCreateAPastryObject_Word()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
    [TestMethod]
    public void TwoAndOneHalfPrice_WillProvideTheCostOfPastryForAnOrderOfThree_Int()
    {
      Pastry testBread = new Pastry();
      int PastryCount = 3;
      int PastryDeal = Pastry.TwoAndOneHalfPrice(PastryCount);
      Assert.AreEqual(5, PastryDeal);
    }

    private static int TwoAndOneHalfPrice(int pastryCount)
    {
      throw new NotImplementedException();
    }
  }
}