using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Pastry.Models;

namespace Pastry.Tests 
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
    public void TwoAndOneHalfPrice_WillProvideTheCostOfPastryDeal_Int()
    {
      Pastry testBread = new Pastry();
      int TwoAndOneHalfPrice = TwoAndOneHalfPrice();
      Assert.AreEqual(5, TwoAndOneHalfPrice());
    }
  }
}