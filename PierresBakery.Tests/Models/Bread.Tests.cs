using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void BreadConstructor_WillCreateABreadObject_Word()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    public void TwoforOne_WillProvideTheCostOfBreadDealForAnOrderOfThree_Int()
    {
      Bread testBread = new Bread();
      int breadCount = 3;
      int breadDeal = Bread.TwoforOne(breadCount);
      Assert.AreEqual(10, breadDeal);
    }

    private static int TwoforOne(int breadCount)
    {
      throw new NotImplementedException();
    }
  }
}